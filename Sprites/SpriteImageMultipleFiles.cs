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
    public class SpriteImageMultipleFiles : SpriteImage
    {
        private AnimationFramesInMultipleFiles frames;
        private int frameNumber;

        public SpriteImageMultipleFiles(AnimationFramesInMultipleFiles frames)
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
                return frames.Images[FrameNumber]; 
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
                SourceRectangle = new Rectangle(0, 0, frames.SpriteSize.Width, frames.SpriteSize.Height);
            }
        }

    }
}
