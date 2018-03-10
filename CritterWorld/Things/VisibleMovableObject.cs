using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using CritterBrains;
using Sprites;

namespace CritterWorld
{
    public class VisibleMovableObject : VisibleObject
    {
        VisibleObject lastTouchingObject = null;

        public VisibleMovableObject(World world, Sprite sprite, int boundingRadius)
            : base(world, sprite, boundingRadius)
        {
            sprite.RepositionApproverDelegate = this.RepositionApprover;
        }

        // Handle an event.  If consumed by this object, return true.
        public override bool HandleEvent(Message message)
        {
            if (base.HandleEvent(message))
            {
                return true;
            }
            if (message is MessageNotifyCloseToObject)
            {
                NotifyCloseToObject(((MessageNotifyCloseToObject)message).CloseToObject);
                return true;
            }
            else if (message is MessageNotifyBlockedByTerrain)
            {
                NotifyBlockedByTerrain();
                return true;
            }
            return false;
        }

        private bool RepositionApprover(Point oldPosition, Point newPosition)
        {
            if (Speed == 0)
            {
                return false;
            }
            bool approved = false;
            if (IsCollisionWithTerrain(newPosition, BoundingRadius))
            {
                // Stop the object and notify it that it has hit the wall
                lastTouchingObject = null;
                Speed = 0;
                SendMessage(new MessageNotifyBlockedByTerrain());
            } 
            else
            {
                // Check if we are blocked by another VisibleObject
                VisibleObject touchingObject = World.GetTouching(this);
                if (touchingObject != null && touchingObject != lastTouchingObject)
                {
                    if (touchingObject.IsBlockingObject())
                    {
                        // We have hit another object that blocks us; we'll reset the old position
                        lastTouchingObject = touchingObject;
                    }
                    Logger.OutputToLog("Bump " + this + " into " + touchingObject, Logger.LogLevel.Message);
                    DoNotifyBumped(touchingObject);
                }
                else
                {
                    lastTouchingObject = null;
                    // We haven't hit anything.  Now look to see if we
                    // are within a reasonable range of anything
                    foreach (VisibleObject objectInRange in World.GetObjectsCloseBy(this, BoundingRadius * 8))
                    {
                        SendMessage(new MessageNotifyCloseToObject(objectInRange));
                    }
                    approved = true;
                }
            }
            return approved;
        }

        private class ScanInfo : IWorldObject
        {
            public ScanInfo(VisibleObject thing)
            {
                this.X = thing.X;
                this.Y = thing.Y;
                this.Type = thing.Type;
            }
            public int X { get; }
            public int Y { get; }
            public string Type { get; }
        }

        public IWorldObject[] Scan()
        {
            List<IWorldObject> nearbyObjects = new List<IWorldObject>();
            foreach (VisibleObject objectInRange in World.GetObjectsCloseBy(this, BoundingRadius * 8))
            {
                nearbyObjects.Add(new ScanInfo(objectInRange));
            }
            return nearbyObjects.ToArray();
        }

        public int Speed
        {
            get
            {
                return sprite.Velocity;
            }
            set
            {
                sprite.Velocity = value;
                sprite.IsMoving = (value > 0);
            }
        }

        public int Direction
        {
            get
            {
                return sprite.Direction;
            }
            set
            {
                sprite.Direction = value;   
            }
        }

        public bool IsTerrainBlockingRouteTo(IWorldObject worldObject)
        {
            return IsTerrainBlockingRouteTo(worldObject.X, worldObject.Y);
        }

        public int GetDistanceBetween(int aX, int aY, int bX, int bY)
        {
            int deltaXSquared = aX - bX;
            deltaXSquared *= deltaXSquared;
            int deltaYSquared = aY - bY;
            deltaYSquared *= deltaYSquared;
            return (int)Math.Sqrt(deltaXSquared + deltaYSquared);
        }

        public bool IsTerrainBlockingRouteTo(int x, int y)
        {
            return IsCollisionWithTerrain(Position, new Point(x, y), BoundingRadius);
        }

        // Return true if rectangular region collides with edge of world or terrain.
        private bool IsCollisionWithTerrain(Point location, int boundingRadius)
        {
            int boundingDiameter = boundingRadius * 2;
            return (!World.Map.IsClearOfTerrain(location.X, location.Y, boundingDiameter, boundingDiameter));
        }

        // Use Bresenham's line algorithm to detect if a line, defined by a circle of
        // a given radius moved from startFrom to endsAt, intersects with terrain.
        private bool IsCollisionWithTerrain(Point startFrom, Point endsAt, int boundingRadius)
        {
            int x0 = startFrom.X;
            int y0 = startFrom.Y;
            int dx = Math.Abs(endsAt.X - x0);
            int dy = Math.Abs(endsAt.Y - y0);
            int sx = (x0 < endsAt.X) ? 1 : -1;
            int sy = (y0 < endsAt.Y) ? 1 : -1;
            int err = dx - dy;
            int boundingDiameter = boundingRadius * 2;

            while (true)
            {
                if (!World.Map.IsClearOfTerrain(x0, y0, boundingDiameter, boundingDiameter))
                {
                    return true;
                }
                if (x0 == endsAt.X && y0 == endsAt.Y)
                {
                    return false;
                }
                int e2 = 2 * err;
                if (e2 > -dy)
                {
                    err -= dy;
                    x0 += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y0 += sy;
                }
            }
        }

        public override bool IsBlockingObject()
        {
            return false;
        }
        
        private void DoNotifyBumped(VisibleObject touchingObject)
        {
            SendMessage(new MessageNotifyBumped(touchingObject));
            touchingObject.SendMessage(new MessageNotifyBumped(this));
        }

        protected override void NotifyBumped(VisibleObject bumpedObject)
        {
            Speed = 0;
            base.NotifyBumped(bumpedObject);
        }

        public virtual void NotifyCloseToObject(VisibleObject objectCloseBy)
        {
        }

        public virtual void NotifyBlockedByTerrain()
        {
        }

        public override void Die(string why)
        {
            base.Die(why);
            Speed = 0;
        }

    }
}
