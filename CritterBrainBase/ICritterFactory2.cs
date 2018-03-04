using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CritterBrainBase;

namespace CritterBrainBase
{
    public interface ICritterFactory2
    {
        IEnumerable<CritterBrainCore> GetCritterBrains();
    }
}
