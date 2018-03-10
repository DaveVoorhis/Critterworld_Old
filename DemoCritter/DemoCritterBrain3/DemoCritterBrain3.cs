using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CritterBrains;

namespace DemoCritter
{
    public class DemoCritterBrain3 : CritterBrains.CritterBrain
    {
        Random random = new Random();

        public DemoCritterBrain3() : base("Aggressive", "Wayne Rippin")
        {
        }

        public override void Birth()
        {
            Critter.Direction = random.Next(0, 360);
            Critter.Speed = 10;
        }

        public override void NotifyBlockedByTerrain()
        {
            Critter.Direction = Critter.Direction + random.Next(0, 360);
            Critter.Speed = 5;
        }

        public override void NotifyBumpedCritter(OtherCritter other)
        {
            if (other.Strength == Strength.MuchWeaker ||
                other.Strength == Strength.Weaker)
            {
                other.Attack();
                Critter.Speed = 1;
            }
            else
            {
                Critter.Direction = Critter.Direction + 180;
                Critter.Speed = 10;
            }
        }

        public override void NotifyEaten()
        {
            Critter.Speed = 1;
        }

        public override void NotifyCloseToFood(int x, int y)
        {
            if (!Critter.IsTerrainBlockingRouteTo(x, y))
            {
                int newDirection = Critter.GetDirectionTo(x, y);
                Critter.Direction = newDirection;
                Critter.Speed = 3;
            }
        }

        public override void NotifyCloseToCritter(OtherCritter otherCritter)
        {
            if (!otherCritter.IsTerrainBlockingRouteTo &&
                (otherCritter.Strength == Strength.Weaker ||
                 otherCritter.Strength == Strength.MuchWeaker))
            {
                Critter.Direction = otherCritter.DirectionTo;
                Critter.Speed = 10;
            }
        }

    }
}
