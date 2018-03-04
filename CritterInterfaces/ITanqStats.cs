using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TanqInterfaces
{
    public interface ITanqStats
    {
        string Name { get; }
        int Hits { get; set; }
        int HitsTaken { get; set; }
    }
}
