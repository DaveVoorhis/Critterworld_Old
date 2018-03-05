using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;

namespace Sprites
{
    /// <summary>
    /// The sprite environment.
    /// Original class by Sasha Djurovic, djurovic@nyc.rr.com
    /// see http://www.codeproject.com/KB/GDI-plus/sprites.aspx
    /// heavily modified by DMVoorhis, d.voorhis@derby.ac.uk
    /// </summary>
    public class SpriteEnvironment
    {
        private Image theBackBuffer; // back buffer
        private int clips = 0; // number of clips, 0 means each sprite gets own clip
        private List<Rectangle> clipRectangles = new List<Rectangle>(); // list of rectangles that need to be erased
        private List<Sprite> renderRequests = new List<Sprite>(); // render requests 
        private bool requestRenderBackground = false;
        private SpriteCollection library = new SpriteCollection(); // sprites we manage
        private PictureBox display;
        private Object locker = new Object();
        private Queue<Sprite> addQueue = new Queue<Sprite>();
        private Queue<Sprite> removeQueue = new Queue<Sprite>();
        private delegate void AnimateDelegate();
        private AnimateDelegate animateDelegate;

        // Used for FPS calculations
        private int renderCalls = 0;
        private long renderTime = 0;

        // Render thread
        private Thread renderThread = null;
        private bool renderThreadActive = false;

        public static Image GetImageFromResource(string imageName)
        {
            System.IO.Stream stream = System.Reflection.Assembly.LoadFrom("CritterWorld.exe").GetManifestResourceStream("CritterWorld.Images." + imageName);
            if (stream != null)
            {
                return Image.FromStream(stream);
            }
            else
            {
                // If not found in resources, look in Images directory.
                return Image.FromFile("Images/" + imageName);
            }
        }
 
        public SpriteEnvironment(PictureBox box)
        {
            display = box;
            theBackBuffer = new Bitmap(display.ClientRectangle.Width, display.ClientRectangle.Height);
            display.Paint += new System.Windows.Forms.PaintEventHandler(RePaint);
            animateDelegate = Animate;
        }

        private void StartRendererThread()
        {
            renderThread = new Thread(new ThreadStart(Renderer));
            renderThread.Name = "Renderer";
            renderThread.Start();
        }

        public void Animate()
        {
            lock (locker)
            {
                UpdateSprites();
                DoRendering();
            }
        }

        const int everyNthRenderPasses = 3;
        int everyNthRenderPass = everyNthRenderPasses;

        private void Renderer()
        {
            renderThreadActive = true;
            while (renderThreadActive)
            {
                lock (addQueue)
                {
                    while (addQueue.Count > 0)
                    {
                        AddSpriteInternal(addQueue.Dequeue());
                    }
                }
                lock (removeQueue)
                {
                    while (removeQueue.Count > 0)
                    {
                        RemoveSpriteInternal(removeQueue.Dequeue());
                    }
                }
                display.Invoke(animateDelegate);
                // We're done.  Give up context to other threads.
                // This peculiar bit of code ensures that Thread.Sleep(0)
                // is normally called, but everyNthRenderPasses we
                // call Thread.Sleep(1) to reduce CPU use by this thread.
                // This helps keep the GUI thread (and hence the GUI)
                // responsive without significantly slowing animation.
                if (--everyNthRenderPass == 0)
                {
                    Thread.Sleep(1);
                    everyNthRenderPass = everyNthRenderPasses;
                }
                else
                {
                    Thread.Sleep(0);
                }
            }
        }

        public void Shutdown()
        {
            renderThreadActive = false;
            if (renderThread == null)
            {
                return;
            }
            for (int i = 0; i < 5; i++)
            {
                if (!renderThread.IsAlive)
                {
                    return;
                }
                Thread.Sleep(250);
            }
            renderThread.Abort();
            Application.Exit();
        }

        #region Sprites

        private void AddSpriteInternal(Sprite sprite)
        {
            sprite.ZOrder = library.Count;
            library.Add(sprite);
            RequestRendering(sprite);
        }

        public void AddSprite(Sprite sprite)
        {
            lock (addQueue)
            {
                addQueue.Enqueue(sprite);
            }
        }

        private void RemoveSpriteInternal(Sprite sprite)
        {
            RequestErasure(sprite);
            sprite.Image = null;
            library.Remove(sprite);
        }

        public void RemoveSprite(Sprite sprite)
        {
            lock (removeQueue)
            {
                removeQueue.Enqueue(sprite);
            }
        }

        public void BringToFront(Sprite sprite)
        {
            lock (locker)
            {
                // the following is the highest z index
                int top = library.Count - 1;
                // search from top and find selected with highest z-order
                for (int count = top; count >= 0; count--)
                {
                    // we found it
                    if (sprite == library.SortedByZ[count]) 
                    {
                        for (int down = count; down < top; down++)
                        {
                            library.SortedByZ[down] = library.SortedByZ[down + 1];
                        }
                        // we put it on top, rest goes below
                        library.SortedByZ[top] = sprite;
                        break;
                    }
                }
            }
        }

        public void Move(Sprite sprite, Point moveTo)
        {
            lock (locker)
            {
                RequestErasure(sprite);
                sprite.Position = moveTo;
                RequestRendering(sprite);
            }
        }

        public void Resize(Sprite sprite, double scale)
        {
            lock (locker)
            {
                RequestErasure(sprite);
                sprite.Scale = scale;
                RequestRendering(sprite);
            }
        }

        #endregion

        #region Event handlers

        public void RePaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            lock (locker)
            {
                // get device context to back buffer
                Graphics backBuffer = Graphics.FromImage(theBackBuffer);
                // draw box.BackgroundImage if any
                if (display.BackgroundImage != null)
                {
                    backBuffer.DrawImage(display.BackgroundImage, e.ClipRectangle, e.ClipRectangle, GraphicsUnit.Pixel);
                }
                // draw sprites
                foreach (Sprite sprite in library.SortedByZ)
                {
                    if (sprite.Image != null)
                    {
                        backBuffer.DrawImage(sprite.Image.Image, sprite.DestinationRectangle, sprite.Image.SourceRectangle, GraphicsUnit.Pixel);
                    }
                }
                // clear it up
                renderRequests.Clear();
                clipRectangles.Clear();
                // blit to front
                display.CreateGraphics().DrawImage(theBackBuffer, display.ClientRectangle);
                // Only after the first paint are we free to start the renderer thread,
                // otherwise rendering may be attempted on a partially-drawn window.
                if (renderThread == null)
                {
                    StartRendererThread();
                }
            }
        }

        private void DoRendering()
        {
            // used to calculate FPS as a performance monitor
            if (renderCalls == 0)
            {
                renderTime = DateTime.Now.Ticks;
            }
            renderCalls++;
            // any requests?
            if (renderRequests.Count > 0)
            {
                if (clips > 0)
                {
                    // create clip regions
                    CreateClips();
                    Render();
                }
                else
                {
                    // use sprite as clip
                    RenderEachClipped();
                }
            }
        }

        private void UpdateSprites()
        {
            // Use for instead of foreach because Library might be modified during loop.
            for (int i = 0; i < library.Count; i++)
            {
                Sprite sprite = library[i];
                bool needsRendering = false;
                needsRendering = sprite.Image != null && sprite.Image.IsAnimated && sprite.Image.UpdateAnimation();
                if (sprite.IsMoving && sprite.CanUpdatePosition())
                {
                    RequestErasure(sprite);
                    needsRendering = sprite.Reposition();
                }
                if (needsRendering)
                {
                    RequestRendering(sprite);
                }
            }
        }

        #endregion

        #region Requests for rendering and erasure

        // request rendering for all sprites
        public void RequestRendering()
        {
            lock (locker)
            {
                requestRenderBackground = true;
                foreach (Sprite sprite in library)
                {
                    renderRequests.Add(sprite);
                }
            }
        }

        // request rendering for a particular sprite
        public bool RequestRendering(Sprite sprite)
        {
            lock (locker)
            {
                // check if sprite within viewport
                if (display.ClientRectangle.IntersectsWith(sprite.DestinationRectangle) || display.ClientRectangle.Contains(sprite.DestinationRectangle))
                {
                    if (renderRequests.Contains(sprite))
                    {
                        return false;
                    }
                    renderRequests.Add(sprite);
                    return true;
                }
                return false;
            }
        }

        // remove request for sprite
        private void RemoveRequestRendering(Sprite sprite)
        {
            renderRequests.Remove(sprite);
        }

        private void RequestErasure(Sprite sprite)
        {
            // check if sprite within viewport
            if (display.ClientRectangle.IntersectsWith(sprite.DestinationRectangle) || display.ClientRectangle.Contains(sprite.DestinationRectangle))
            {
                clipRectangles.Add(sprite.DestinationRectangle);
                GetObjectsUnderneath(sprite);
            }
        }

        #endregion

        #region Rendering routines

        private void DrawSprites(Graphics backBuffer)
        {
            // draw sprites
            foreach (Sprite sprite in library.SortedByZ)
            {
                if (renderRequests.Contains(sprite) && sprite.Image != null)
                {
                    backBuffer.DrawImage(sprite.Image.Image, sprite.DestinationRectangle, sprite.Image.SourceRectangle, GraphicsUnit.Pixel);
                }
            }
            // clear it up
            renderRequests.Clear();
            clipRectangles.Clear();
            // blit to front
            display.CreateGraphics().DrawImage(theBackBuffer, display.ClientRectangle);
        }

        private void RenderEachClipped()
        {
            // get dc to back buffer
            Graphics backBuffer = Graphics.FromImage(theBackBuffer);
            // draw background image, if any
            if (display.BackgroundImage != null && requestRenderBackground)
            {
                backBuffer.DrawImage(display.BackgroundImage, display.ClientRectangle, display.ClientRectangle, GraphicsUnit.Pixel);
            }
            // render erasure requests
            foreach (Rectangle rectangle in clipRectangles)
            {
                backBuffer.DrawImage(display.BackgroundImage, rectangle, rectangle, GraphicsUnit.Pixel);
            }
            // request objects that get drawn over
            // foreach cannot be used here, because renderRequestList is changed by GetObjectsUnderneath
            for (int i = 0; i < renderRequests.Count; i++)
            {
                GetObjectsUnderneath(renderRequests[i]);
            }
            // draw box.BackgroundImage
            foreach (Sprite sprite in library.SortedByZ)
            {
                if (renderRequests.Contains(sprite))
                {
                    backBuffer.DrawImage(display.BackgroundImage, sprite.DestinationRectangle, sprite.DestinationRectangle, GraphicsUnit.Pixel);
                }
            }
            DrawSprites(backBuffer);
        }

        // renders only requested
        private void Render()
        {
            Graphics backBuffer = Graphics.FromImage(theBackBuffer);
            if (display.BackgroundImage != null)
            {
                if (requestRenderBackground)
                {
                    backBuffer.DrawImage(display.BackgroundImage, display.ClientRectangle, display.ClientRectangle, GraphicsUnit.Pixel);
                    requestRenderBackground = false;
                }
                else
                {
                    foreach (Rectangle rectangle in clipRectangles)
                    {
                        backBuffer.DrawImage(display.BackgroundImage, rectangle, rectangle, GraphicsUnit.Pixel);
                    }
                }
            }
            DrawSprites(backBuffer);
        }

        #endregion

        #region Clips

        private Rectangle MergeClips(Rectangle clip1, Rectangle clip2)
        {
            int x, y, width, height;

            if (clip1.X < clip2.X)
            {
                x = clip1.X;
            }
            else
            {
                x = clip2.X;
            }
            if (clip1.X + clip1.Width > clip2.X + clip2.Width)
            {
                width = clip1.X + clip1.Width - x;
            }
            else
            {
                width = clip2.X + clip2.Width - x;
            }
            if (clip1.Y < clip2.Y)
            {
                y = clip1.Y;
            }
            else
            {
                y = clip2.Y;
            }
            if (clip1.Y + clip1.Height > clip2.Y + clip2.Height)
            {
                height = clip1.Y + clip1.Height - y;
            }
            else
            {
                height = clip2.Y + clip2.Height - y;
            }
            return new Rectangle(x, y, width, height);
        }

        private void CreateClips()
        {
            // each request has its own clip rectangle; get them
            // on top of erase requests
            foreach (Sprite sprite in renderRequests)
            {
                clipRectangles.Add(sprite.DestinationRectangle);
                GetObjectsUnderneath(sprite);
            }
            GetNotRequested();
            // we'll be merging clips until we get desired number of clips
            // for(int clipsCount=Total;clipsCount>pClips;clipsCount--)
            while (clipRectangles.Count > clips)
            {
                minArea = 1000000;
                FindMinArea(clipRectangles.Count - 1);
                //use one on bottom
                clipRectangles.RemoveAt(minIndexB);
                clipRectangles.Insert(minIndexB, minRect);
                //don't use the one on top anymore
                clipRectangles.RemoveAt(minIndexA);
            }
            // Possibly we need to make some more requests 
            // for sprites covered with new clips and not requested originally
            if (renderRequests.Count + NotRequested.Count != library.Count)
            {
                foreach (Sprite sprite in library)
                {
                    RequestRendering(sprite);
                }
                foreach (Sprite sprite in NotRequested)
                {
                    RemoveRequestRendering(sprite);
                }
            }
        }

        private Rectangle minRect; // used for recursive FindMinArea()
        private int minArea; // same
        private int minIndexA; // same
        private int minIndexB; // same

        private void FindMinArea(int index)
        {
            for (int count = index - 1; count >= 0; count--)
            {
                // Hmmm... Some questionable stuff here.  Revisit this.  I DIDN'T WRITE IT, so don't blame me.
                //  -- Dave
                Rectangle temp;
                temp = MergeClips(clipRectangles[index], clipRectangles[count]);
                // check for objects underneath that didn't request rendering
                GetNotRequested();
                temp = MergeObjectsUnderneath(temp);
                int area = temp.Width * temp.Height;
                if (area < minArea)
                {
                    minArea = area;
                    minRect = temp;
                    minIndexA = index;
                    minIndexB = count;
                }
            }
            if (index > 1)
            {
                FindMinArea(index - 1);
            }
        }

        private void GetObjectsUnderneath(Sprite topSprite)
        {
            Rectangle RectA = topSprite.DestinationRectangle;
            foreach (Sprite sprite in library)
            {
                Rectangle RectB = sprite.DestinationRectangle;
                if (Intersect(RectA, RectB))
                {
                    RequestRendering(sprite);
                }
            }
        }

        // we need it for later recursive MergeObjectsUnderneath
        private List<Sprite> NotRequested = new List<Sprite>();

        private void GetNotRequested()
        {
            NotRequested.Clear();
            foreach (Sprite sprite in library)
            {
                if (!renderRequests.Contains(sprite))
                {
                    NotRequested.Add(sprite);
                }
            }
        }

        private bool Intersect(Rectangle RectA, Rectangle RectB)
        {
            // check for intersecting rectangles
            if (RectA.IntersectsWith(RectB))
            {
                return true;
            }
            // check for contained (one inside the other)
            if (RectA.Contains(RectB) || RectB.Contains(RectA))
            {
                return true;
            }
            return false;
        }

        private Rectangle MergeObjectsUnderneath(Rectangle rect)
        {
            foreach (Sprite sprite in NotRequested)
            {
                Rectangle RectB = sprite.DestinationRectangle;
                if (Intersect(RectB, rect))
                {
                    NotRequested.Remove(sprite);
                    return MergeObjectsUnderneath(MergeClips(rect, RectB));
                }
            }
            return rect;
        }

        #endregion

        #region Misc.

        public int GetSystemFPS()
        {
            if (renderCalls != 0 && DateTime.Now.Ticks != renderTime)
            {
                int result = Convert.ToInt32(10000000 / ((DateTime.Now.Ticks - renderTime) / renderCalls));
                renderCalls = 0;
                return result;
            }
            else return 0;
        }

        #endregion
    }
}
