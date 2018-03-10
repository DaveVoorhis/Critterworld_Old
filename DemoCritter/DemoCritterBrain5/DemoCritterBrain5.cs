using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CritterBrains;

namespace DemoCritter
{
    public class DemoCritterBrain5 : CritterBrains.CritterBrain
    {
        Random randomizer = new Random();
        int nominalSpeed = 10;
        int sideWaysDirection = 90;
        int reverseDirection = 180;

        public DemoCritterBrain5() : base("DeadReckoner", "Dave Voorhis")
        {
        }

        public override void Think()
        {
            Rectangle destination = Critter.GetDestination();
            int centreDestinationX = destination.X + destination.Width / 2;
            int centreDestinationY = destination.Y + destination.Height / 2;
            if (!Critter.IsTerrainBlockingRouteTo(centreDestinationX, centreDestinationY)) {
                int direction = Critter.GetDirectionTo(centreDestinationX, centreDestinationY);
                Critter.Direction = direction;
                Critter.Speed = nominalSpeed;
            }
        }

        public override void Birth()
        {
            Critter.Direction = sideWaysDirection;
            Critter.Speed = nominalSpeed;
        }

        public override void NotifyBlockedByTerrain()
        {
            Critter.Direction = Critter.Direction + sideWaysDirection;
            Critter.Speed = nominalSpeed;
        }

        public override void NotifyBumpedCritter(OtherCritter other)
        {
            Critter.Direction = Critter.Direction + reverseDirection;
            Critter.Speed = nominalSpeed;
        }

        public override void NotifyCloseToFood(int x, int y)
        {
            int newDirection = Critter.GetDirectionTo(x, y);
            Critter.Direction = newDirection;
            Critter.Speed = nominalSpeed;
        }

        int lastPoopX = -1;
        int lastPoopY = -1;

        public override void NotifyCloseToPoop(int x, int y)
        {
            if (x == lastPoopX && y == lastPoopY)
                return;
            lastPoopX = x;
            lastPoopY = y;
            Critter.Direction = Critter.Direction + sideWaysDirection;
            Critter.Speed = nominalSpeed;
        }
    }
}
