using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using CritterBrainBase;

namespace DemoCritter
{
    public class DemoCritterBrain1 : CritterBrainCore
    {
        Random random = new Random();
        DateTime lastMovementTime;
        int randomIntervalInSeconds;

        public DemoCritterBrain1() : base("Drunkard", "Wayne & Dave")
        {
        }

        public override void Birth()
        {
            DoRandomDirection();
        }

        private void DoRandomDirection() 
        {
            Critter.Direction = random.Next(0, 360);
            Critter.Move(10);
            lastMovementTime = DateTime.Now;
            randomIntervalInSeconds = random.Next(1, 5);
        }

        public override void Think()
        {
            int timePast = DateTime.Now.Subtract(lastMovementTime).Seconds;
            if (timePast >= randomIntervalInSeconds)
            {
                DoRandomDirection();
            }
        }
        
        public override void NotifyBlockedByTerrain()
        {
            Critter.Direction = Critter.Direction - 10;
            Critter.Move(10);
        }

        public override void NotifyBumpedCritter(OtherCritter other)
        {
            Critter.Direction = Critter.Direction + 180;
            Critter.Move(10);
        }

        public override void NotifyCloseToFood(int x, int y)
        {
            Critter.Direction = Critter.GetDirectionTo(x, y);
        }

        public override void NotifyCloseToCritter(OtherCritter otherCritter)
        {
            Critter.Direction = otherCritter.DirectionTo + 180;
        }
    }
}
