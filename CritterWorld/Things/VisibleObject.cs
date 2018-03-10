using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using CritterBrains;
using Sprites;

namespace CritterWorld
{
    public class VisibleObject : IWorldObject
    {
        static long objectNumberGenerator = 0;

        World world;
        int boundingRadius;
        bool isDead = false;
        Thread eventPump;
        Queue<Message> messageQueue = new Queue<Message>();
        long objectNumber;
        string deadReason;

        protected Sprite sprite;

        public VisibleObject(World world, Sprite sprite, int boundingRadius) 
        {
            this.world = world;
            this.sprite = sprite;
            this.boundingRadius = boundingRadius;
            this.objectNumber = ++objectNumberGenerator;
            deadReason = "";
            Position = world.GetRandomLocation(Width, Height);
            world.AllObjects.Add(this);
            world.Add(sprite);
            eventPump = new Thread(new ThreadStart(PumpEvents));
            eventPump.Name = "EventPump" + objectNumber;
            eventPump.Start();
            eventPump.Priority = ThreadPriority.BelowNormal;
        }

        public void SendMessage(Message m)
        {
            lock (messageQueue)
            {
                messageQueue.Enqueue(m);
            }
        }

        private void PumpEvents()
        {
            while (!isDead)
            {
                Message nextMessage = null;
                lock (messageQueue)
                {
                    if (messageQueue.Count > 0)
                    {
                        nextMessage = messageQueue.Dequeue();
                    }
                }
                if (nextMessage != null)
                {
                    try
                    {
                        HandleEvent(nextMessage);
                    }
                    catch (Exception e)
                    {
                        String who = "System";
                        if (this is Critter critter)
                        {
                            critter.Die("Crashed");
                            CritterWorldForm.AddMarqueeMessage((string)(critter.CritterBrain.Name + " by " + critter.CritterBrain.Creator + " crashed."));
                            who = ((Critter)this).File;
                        }
                        Logger.OutputToLog("HandleEvent crashed processing message " + nextMessage.GetType().ToString() + " in " + who + "'s VisibleObject.PumpEvents: " + e.Message, Logger.LogLevel.Error);
                    }
                }
                // Do other stuff.
                Processing();
                // Give up context to another thread.
                Thread.Sleep(1);
            }
        }

        public virtual void Processing() 
        {
        }

        // Handle an event.  If consumed by this object, return true.
        public virtual bool HandleEvent(Message message)
        {
            if (message is MessageNotifyBumped)
            {
                NotifyBumped(((MessageNotifyBumped)message).BumpedObject);
                return true;
            }
            return false;
        }

        public Point Position
        {
            get
            {
                return sprite.Position;
            }
            set
            {
                sprite.Position = value;
            }
        }

        public int X
        {
            get
            {
                return Position.X;
            }
        }

        public int Y
        {
            get
            {
                return Position.Y;
            }
        }

        public int Width
        {
            get
            {
                return sprite.Size.Width;
            }
        }

        public int Height
        {
            get
            {
                return sprite.Size.Height;
            }
        }

        public int BoundingRadius
        {
            get
            {
                return boundingRadius;
            }
        }

        public World World
        {
            get
            {
                return world;
            }
        }

        public bool IsDead
        {
            get
            {
                return isDead;
            }
        }

        public string DeadReason
        {
            get
            {
                return deadReason;
            }
        }

        protected virtual void NotifyBumped(VisibleObject bumpedObject)
        {
        }

        public virtual bool IsBlockingObject()
        {
            return false;
        }

        // Return true if two regions defined by a point and a radius (i.e., circles) overlap.
        public static bool IsOverlapping(Point aPoint, int aRadius, Point bPoint, int bRadius) {
            int deltaXSquared = aPoint.X - bPoint.X;
            deltaXSquared *= deltaXSquared;
            int deltaYSquared = aPoint.Y - bPoint.Y;
            deltaYSquared *= deltaYSquared;
            // Calculate the sum of the radii, then square it
            int sumRadiiSquared = aRadius + bRadius;
            sumRadiiSquared *= sumRadiiSquared;
            return (deltaXSquared + deltaYSquared <= sumRadiiSquared);
        }

        // Return true if this object is in collision with a VisibleObject bounded by
        // a specified radius.  Note that a VisibleObject's coordinates are defined
        // starting from the upper left corner of the object, so its bounding
        // radius must be added to both X and Y coordinates to obtain the centre
        // of the object.
        public bool IsTouching(VisibleObject other, int radius)
        {
            int aX = X + boundingRadius;
            int aY = Y + boundingRadius;
            int bX = other.X + other.boundingRadius;
            int bY = other.Y + other.boundingRadius;
            return IsOverlapping(new Point(aX, aY), boundingRadius, new Point(bX, bY), radius);
        }

        // As above, but return true if this object is in collision with a circle.
        public bool IsTouching(Point center, int radius)
        {
            int aX = X + boundingRadius;
            int aY = Y + boundingRadius;
            return IsOverlapping(new Point(aX, aY), boundingRadius, center, radius);
        }

        // As above, using the other object's boundingRadius
        public bool IsTouching(VisibleObject other)
        {
            return IsTouching(other, other.boundingRadius);
        }

        // As above, but is this object in collision with a rectangle?
        public bool IsTouching(Rectangle otherRectangle)
        {
            Rectangle myRectangle = new Rectangle(X, Y, Width, Height);
            return myRectangle.IntersectsWith(otherRectangle);
        }

        public virtual void Die(string reason)
        {
            isDead = true;
            deadReason = reason;
            world.Remove(sprite);
        }

        public int GetDirectionTo(int x, int y)
        {
            if (Position.X == x && Position.Y == y)
            {
                return 0;
            }
            // Atan2(x - this.X, this.Y - y) gets direction in screen coordinates
            double degrees = Math.Atan2(x - this.X, this.Y - y) * 180.0 / Math.PI % 360;
            if (degrees < 0)
            {
                degrees += 360;
            }
            return (int)degrees;
        }

        public int GetDirectionTo(IWorldObject other)
        {
            return GetDirectionTo(other.X, other.Y);
        }

        public string Type
        {
            get
            {
                return GetType().Name;
            }
        }
    }
}
