using System;
using System.Windows.Forms;
using CritterBrainBase;

namespace DemoCritter
{
    public class DemoCritterBrain1 : CritterBrainCore
    {
        Random random = new Random();
        DateTime lastMovementTime;
        int randomIntervalInSeconds;
        int nominalSpeed = 10;

        public DemoCritterBrain1() : base("Drunkard", "Wayne & Dave")
        {
        }

        public override void Birth()
        {
            DoRandomDirection();
        }

        public override Form Form {
            get
            {
                return new DemoCritterBrain1ConfigForm(this);
            }
        }

        public int Speed
        {
            get
            {
                return nominalSpeed;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Speed must be greater than or equal to zero.");
                }
                nominalSpeed = value;
            }
        }

        private void DoRandomDirection() 
        {
            Critter.Direction = random.Next(0, 360);
            Critter.Move(nominalSpeed);
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
            Critter.Move(nominalSpeed);
        }

        public override void NotifyBumpedCritter(OtherCritter other)
        {
            Critter.Direction = Critter.Direction + 180;
            Critter.Move(nominalSpeed);
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
