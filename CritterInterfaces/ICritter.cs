using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CritterInterfaces
{
    public interface ICritter
    {
        void MoveCritter(int speed);
        void StopCritter();
        int Speed { get; }
        int Direction { set; get; }
        int Energy { get; }
        int Age { get; }
        int GetDirectionTo(IWorldObject other);
        int GetDirectionTo(int x, int y);
        Rectangle GetDestination();
        bool IsTerrainBlockingRouteTo(int x, int y);
        bool IsTerrainBlockingRouteTo(IWorldObject other);
        Strength GetStrengthOf(IOtherCritter otherCritter);
        void Attack(IOtherCritter otherCritter);
    }
}
