using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Sprites
{
    /// <summary>
    /// Encapsulates a sprite's animation frames.
    /// class by Sasha Djurovic, djurovic@nyc.rr.com
    /// see http://www.codeproject.com/KB/GDI-plus/sprites.aspx
    /// modified by DMVoorhis, d.voorhis@derby.ac.uk
    /// </summary>
    public class AnimationFramesInOneFile
    {
        private Point layout = new Point(10, 6);
        private Image image;
        private Size spriteSize = new Size(64, 64);
        private int numberOfFrames = 60;

        public AnimationFramesInOneFile() { }

        public AnimationFramesInOneFile(string fName)
        {
            Image = new System.Drawing.Bitmap(fName);
        }

        /// <summary>
        /// Source file for sprites
        /// </summary>
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                spriteSize = new Size(Convert.ToInt32(image.Size.Width / layout.X),
                    Convert.ToInt32(image.Size.Height / layout.Y));
            }
        }

        /// <summary>
        /// layout of sprites in source image file
        /// </summary>
        public Point ImageLayout
        {
            get
            {
                return layout;
            }
            set
            {
                layout = value;
                if (image != null)
                {
                    spriteSize = new Size(Convert.ToInt32(image.Size.Width / layout.X),
                        Convert.ToInt32(image.Size.Height / layout.Y));
                }
                numberOfFrames = layout.X * layout.Y;
            }
        }

        public Size SpriteSize
        {
            get
            {
                return spriteSize;
            }
        }

        public int NumberOfFrames
        {
            get
            {
                return numberOfFrames;
            }
        }
    }
}
