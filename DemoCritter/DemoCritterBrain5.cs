using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CritterBrainBase;

namespace DemoCritter
{
    public class DemoCritterBrain5 : CritterBrainCore
    {
        Random randomizer = new Random();

        public DemoCritterBrain5() : base("DeadReckoner", "Dave Voorhis")
        {
        }

        public override void Birth()
        {
            Critter.Direction = 90;
            Critter.Move(10);
        }

        public override void NotifyBlockedByTerrain()
        {
            Critter.Direction = Critter.Direction + 90;
            Critter.Move(10);
        }

        public override void NotifyBumpedCritter(OtherCritter other)
        {
            Critter.Direction = Critter.Direction + 180;
            Critter.Move(10);
        }

         public override void NotifyCloseToFood(int x, int y)
        {
            int newDirection = Critter.GetDirectionTo(x, y);
            Critter.Direction = newDirection;
            Critter.Move(10);
        }

    }
}
