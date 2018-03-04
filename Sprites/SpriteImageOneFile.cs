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
    public class SpriteImageOneFile : SpriteImage
    {
        private AnimationFramesInOneFile frames;
        private int frameNumber = 0;

        public SpriteImageOneFile(AnimationFramesInOneFile frames)
        {
            this.frames = frames;
            FrameNumber = 0;
        }

        public override Size SpriteSize
        {
            get
            {
                return frames.SpriteSize;
            }
        }

        public override Image Image
        {
            get 
            { 
                return frames.Image; 
            }
        }

        public override int FrameNumber
        {
            get
            {
                return frameNumber;
            }
            set
            {
                frameNumber = value % frames.NumberOfFrames;
                Point layout = frames.ImageLayout;
                Size sSize = frames.SpriteSize;
                SourceRectangle = new Rectangle(frameNumber % layout.X * sSize.Width,
                    frameNumber / layout.X * sSize.Height,
                    sSize.Width, sSize.Height);
            }
        }

    }
}
