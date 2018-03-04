using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CritterBrainBase
{
    public interface ICritterBrain
    {
        string Name { get; }
        string Creator { get; }
        Image[] Images { get; }
        ICritter Body { set; }
        void Birth();
        void Think();
        void NotifyBlockedByTerrain();
        void NotifyBumped(IWorldObject otherCritter);
        void NotifyEaten();
        void NotifyCloseToFood(IWorldObject food);
        void NotifyCloseToCritter(IOtherCritter otherCritter);
    }
}
