using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CritterBrains;

namespace CritterBrains
{
    public interface ICritterFactory
    {
        IEnumerable<CritterBrain> GetCritterBrains();
    }
}
