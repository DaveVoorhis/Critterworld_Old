using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CritterBrains
{
    public interface IWorldObject
    {
        string Type { get; }
        int X { get; }
        int Y { get; }
    }
}
