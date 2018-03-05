using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Sprites
{
    /// <summary>
    /// Iterates over a sprite's animation frames.
    /// By DMVoorhis, d.voorhis@derby.ac.uk
    /// </summary>
    public abstract class SpriteImage
    {
        private Rectangle sourceRectangle = new Rectangle(0, 0, 64, 64);
        private bool isAnimated = false;
        private long animationTimestamp = 0;
        private int animationFramesPerSecond;
        private int frameDuration;
        private bool onlyOnce = false;

        public SpriteImage()
        {
            IsAnimated = false;
            FPS = 30;
        }

        public void StartAnimation()
        {
            AnimationTimeStamp = DateTime.Now.Ticks;
            IsAnimated = true;
        }

        public void StopAnimation()
        {
            IsAnimated = false;
            AnimationTimeStamp = 0;
        }

        public abstract Size SpriteSize
        {
            get;
        }

        public abstract Image Image
        {
            get;
        }

        public bool OnlyOnce
        {
            get 
            { 
                return onlyOnce; 
            }
            set 
            { 
                onlyOnce = value; 
            }
        }

        public Rectangle SourceRectangle
        {
            get 
            { 
                return sourceRectangle; 
            }
            set 
            { 
                sourceRectangle = value; 
            }
        }

        public bool IsAnimated
        {
            get 
            { 
                return isAnimated; 
            }
            set 
            { 
                isAnimated = value; 
            }
        }

        public long AnimationTimeStamp
        {
            get 
            { 
                return animationTimestamp; 
            }
            set 
            { 
                animationTimestamp = value; 
            }
        }

        public int FPS
        {
            get 
            { 
                return animationFramesPerSecond; 
            }
            set
            {
                animationFramesPerSecond = value;
                frameDuration = Convert.ToInt32(1000.0 / FPS);
            }
        }

        public abstract int FrameNumber
        {
            get;
            set;
        }

        public bool UpdateAnimation()
        {
            long elapsed = DateTime.Now.Ticks - AnimationTimeStamp;
            if (AnimationTimeStamp == 0) // if we are just starting animation
            {
                Reset();
                AnimationTimeStamp = elapsed;
                return false;
            }
            // 100ns = 10,000 ticks in 1 ms
            int frame = Convert.ToInt32(elapsed / 10000 / frameDuration);
            if (frame > 0)
            {
                NextFrame();
                AnimationTimeStamp = DateTime.Now.Ticks;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            FrameNumber = 0;
        }

        public void NextFrame()
        {
            int oldFrameNumber = FrameNumber;
            FrameNumber = FrameNumber + 1;
            if (oldFrameNumber > FrameNumber && onlyOnce)
            {
                IsAnimated = false;
            }
        }

    }
}
