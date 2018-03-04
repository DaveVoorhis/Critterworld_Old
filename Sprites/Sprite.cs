using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sprites
{
    /// <summary>
    /// A sprite.
    /// class by Sasha Djurovic, djurovic@nyc.rr.com
    /// see http://www.codeproject.com/KB/GDI-plus/aspx
    /// modified by DMVoorhis, d.voorhis@derby.ac.uk
    /// </summary>
    public class Sprite
    {
        private const int maximumVelocity = 10;

        public delegate bool RepositionApprover(Point oldPosition, Point newPosition);

        private SpriteImage image;
        private PointF position = new PointF(0, 0);
        private double scale = 1.0;
        private int zOrder = 0;
        private Size size = new Size(64, 64);
        private Rectangle destinationRectangle = new Rectangle(0, 0, 64, 64);
        private bool isMoving = false;
        private long movementTimestamp = 0;
        private int velocity;
        private int direction;
        private RepositionApprover repositionApprover = null;
        private int invocationsPerTick = 0;
        private bool needsCalibrate = true;
        private int velocityScalingFactor = -1;
        private int invocationsOfCanUpdatePosition = 0;

        public Sprite(SpriteImage image)
        {
            Image = image;
            Size = image.SpriteSize;
            Velocity = 0;
            IsMoving = false;
            Direction = 0;
            repositionApprover = DefaultRepositionApprover;
        }

        public Sprite(SpriteImage image, Point position) : this(image)
        {
            Position = position;
        }

        public Sprite(SpriteImage image, Point position, int fps, bool animated) : this(image, position)
        {
            image.FPS = fps;
            image.IsAnimated = animated;
        }

        public RepositionApprover RepositionApproverDelegate
        {
            get
            {
                return repositionApprover;
            }
            set
            {
                repositionApprover = value;
            }
        }

        public SpriteImage Image 
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        public bool Touches(int x, int y)
        {
            return DestinationRectangle.X < x && DestinationRectangle.Y < y &&
                    DestinationRectangle.X + DestinationRectangle.Width > x &&
                    DestinationRectangle.Y + DestinationRectangle.Height > y;
        }

        public void StartMovement()
        {
            MovementTimeStamp = DateTime.Now.Ticks;
            IsMoving = true;
        }

        public void StopMovement()
        {
            IsMoving = false;
            MovementTimeStamp = 0;
        }

        public bool IsMoving
        {
            get 
            { 
                return isMoving; 
            }
            set 
            { 
                isMoving = value; 
            }
        }

        public long MovementTimeStamp
        {
            get 
            { 
                return movementTimestamp; 
            }
            set 
            { 
                movementTimestamp = value; 
            }
        }

        public int ZOrder
        {
            get 
            { 
                return zOrder; 
            }
            set 
            { 
                zOrder = value; 
            }
        }

        public Size Size
        {
            get 
            { 
                return size; 
            }
            set 
            { 
                size = value; 
            }
        }

        public Rectangle DestinationRectangle
        {
            get 
            { 
                return destinationRectangle; 
            }
            set 
            { 
                destinationRectangle = value; 
            }
        }

        public int Velocity
        {
            get 
            { 
                return velocity; 
            }
            set
            {
                velocity = Math.Max(Math.Min(value, maximumVelocity), 0);
            }
        }

        public int Direction
        {
            get 
            { 
                return direction; 
            }
            set
            {
                if (value < 0)
                {
                    int temp = (-value) % 360;
                    direction = 360 - temp;
                }
                else
                {
                    direction = value % 360;
                }
            }
        }

        public double Scale
        {
            get
            {
                return scale;
            }
            set
            {
                Size oldSize = Size;
                scale = value;
                Size = new Size(Convert.ToInt32(image.SpriteSize.Width * scale), Convert.ToInt32(image.SpriteSize.Height * scale));
                // Position compensation. Two divisions instead of one avoids rounding errors that
                // can cause sprite to change position if scaled up and down repeatedly.
                position.X -= Size.Width / 2 - oldSize.Width / 2;
                position.Y -= Size.Height / 2 - oldSize.Height / 2;
                // Set target rectangle
                DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, Size.Width, Size.Height);
            }
        }

        public Point Position
        {
            get
            {
                return new Point((int)position.X, (int)position.Y);
            }
            set
            {
                position = value;
                DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, Size.Width, Size.Height);
            }
        }

        public static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        private bool DefaultRepositionApprover(Point oldPosition, Point newPosition) 
        {
            return true;
        }

        // Relocate one pixel in Direction degrees
        public bool Reposition()
        {
            double angleInRads = DegreesToRadians((Direction - 90) % 360);
            PointF newPosition = new PointF((float)(position.X + Math.Cos(angleInRads)),
                                            (float)(position.Y + Math.Sin(angleInRads)));
            if (repositionApprover(Position, new Point((int)newPosition.X, (int)newPosition.Y)))
            {
                position = newPosition;
                DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, Size.Width, Size.Height);
                return true;
            }
            return false;
        }

        // Count how many invocations of this method occur in a fixed-time interval.
        // Used for crude velocity/time/load compensation via velocityScalingFactor.
        private void Calibrate()
        {
            invocationsPerTick++;
            if (MovementTimeStamp == 0)
            {
                MovementTimeStamp = DateTime.Now.Ticks;
            }
            else if (DateTime.Now.Ticks - MovementTimeStamp > 1000000L)
            {
                velocityScalingFactor = Math.Max(1, invocationsPerTick / maximumVelocity);
                needsCalibrate = false;
            }
        }

        private void RequestRecalibrate()
        {
            needsCalibrate = true;
            invocationsPerTick = 0;
            MovementTimeStamp = 0;
        }

        // Returns true if position should be updated
        public bool CanUpdatePosition()
        {
            if (needsCalibrate)
            {
                Calibrate();
                if (velocityScalingFactor == -1)
                {
                    return false;
                }
            }
            else
            {
                RequestRecalibrate();
            }
            if (!IsMoving || Velocity == 0)
            {
                return false;
            }
            if (++invocationsOfCanUpdatePosition >= velocityScalingFactor * (maximumVelocity - velocity + 1))
            {
                invocationsOfCanUpdatePosition = 0;
                return true;
            }
            return false;
        }
    }
}
