using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Sprites;

// Version of the PictureBox class used to host CritterWorld graphics.
// Wayne probably wrote this, then Dave ruined it.  It goes like that.

namespace CritterWorld
{
    public class WorldPanel : PictureBox
    {
        private SpriteEnvironment world = null;

        public void CreateWorld()
        {
            DoubleBuffered = false;
            world = new SpriteEnvironment(this);
        }

        public void DestroyWorld()
        {
            if (world != null)
            {
                world.Shutdown();
            }
        }

        public void SetBackground(string fileName)
        {
            Image newImage = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Graphics graphic = Graphics.FromImage(newImage);
            if (fileName == null)
            {
                graphic.FillRectangle(new SolidBrush(Color.White), 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            }
            else
            {
                Image backgroundImage = Utility.GetImageFromResource(fileName);
                if (backgroundImage == null)
                {
                    Console.WriteLine("NOTE: Default background image file '{0}' not found.", fileName);
                    graphic.FillRectangle(new SolidBrush(Color.White), 0, 0, this.ClientSize.Width, this.ClientSize.Height);
                }
                else
                {
                    // Resize the specified image to fit the panel exactly.
                    graphic.DrawImage(backgroundImage, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
                }
            }
            this.BackgroundImage = newImage;
        }

        public void Add(Sprite sprite)
        {
            world.AddSprite(sprite);
        }

        public void Remove(Sprite sprite)
        {
            world.RemoveSprite(sprite);
        }
    }
}
