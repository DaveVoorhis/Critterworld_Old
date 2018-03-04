using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using CritterBrainBase;
using Sprites;

namespace CritterWorld 
{
    public class Goal : VisibleMovableObject
    {
        public const int GoalBoundingRadius = 16;

        public Goal(World world, Sprite sprite, Point position)
            : base(world, sprite, GoalBoundingRadius)
        {
            Position = position;
        }

        protected override void NotifyBumped(VisibleObject bumpedObject)
        {
            if (bumpedObject is Critter)
            {
                ((Critter)bumpedObject).ReachedGoal();
            }
            else
            {
                base.NotifyBumped(bumpedObject);
            }
        }

        public override bool IsBlockingObject()
        {
            return false;
        }

    }
}
