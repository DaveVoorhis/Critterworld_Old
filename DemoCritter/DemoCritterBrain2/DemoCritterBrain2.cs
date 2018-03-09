using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CritterBrainBase;

namespace DemoCritter
{
    public class DemoCritterBrain2 : CritterBrainCore
    {
        Random random = new Random();
        int speed = 10;

        public DemoCritterBrain2() : base("Wired", "Wayne Rippin")
        {
        }

        public override void Birth()
        {
            speed = 10;
            Critter.Direction = random.Next(0, 360);
            Critter.Move(speed);
        }

        public override void Think()
        {
            if (Critter.Energy > 15)
            {
                speed = 10;
            }
            else if (Critter.Energy > 10)
            {
                speed = 7;
            }
            else if (Critter.Energy > 5)
            {
                speed = 5;
            }
            else
            {
                speed = 1;
            }
            Critter.Move(speed);
        }

        public override void NotifyBlockedByTerrain()
        {
            Critter.Direction = Critter.Direction + 90;
            Critter.Move(speed);
        }

        public override void NotifyBumpedCritter(OtherCritter otherCritter)
        {
            Critter.Direction = Critter.Direction + 180;
            Critter.Move(speed);
        }

        public override void NotifyCloseToFood(int x, int y)
        {
            if (!Critter.IsTerrainBlockingRouteTo(x, y))
            {
                int newDirection = Critter.GetDirectionTo(x, y);
                Critter.Direction = newDirection;
            }
        }

        public override void NotifyCloseToCritter(OtherCritter otherCritter)
        {
            if (otherCritter.IsTerrainBlockingRouteTo)
            {
                int newDirection = otherCritter.DirectionTo;
                Critter.Direction = newDirection + random.Next(90, 180);
            }
        }

    }
}
