using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Sprites
{
    /// <summary>
    /// Encapsulates a sprite's animation frames.
    /// by DMVoorhis, d.voorhis@derby.ac.uk
    /// </summary>
    public class AnimationFramesInMultipleFiles
    {
        private List<Image> images = new List<Image>();
        private Size spriteSize = new Size(0, 0);

        public AnimationFramesInMultipleFiles() { }

        public AnimationFramesInMultipleFiles(Image[] images)
        {
            Images = images;
        }

        public AnimationFramesInMultipleFiles(string[] fnames)
        {
            foreach (string fname in fnames)
            {
                Add(fname);
            }
        }

        public void Add(Image image)
        {
            spriteSize = new Size(Math.Max(spriteSize.Width, Convert.ToInt32(image.Size.Width)),
                                   Math.Max(spriteSize.Height, Convert.ToInt32(image.Size.Height)));
            images.Add(image);
        }

        public void Add(string fName)
        {
            Image image = SpriteEnvironment.GetImageFromResource(fName);
            Add(image);
        }

        public Image[] Images
        {
            get
            {
                return images.ToArray();
            }
            set
            {
                images.Clear();
                foreach (Image image in value)
                {
                    Add(image);
                }
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
                return images.Count;
            }
        }
    }
}
