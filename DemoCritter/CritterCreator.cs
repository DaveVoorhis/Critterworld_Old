using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CritterBrains;

namespace DemoCritter
{
    public class CritterCreator : ICritterFactory
    {
        const int totalCritterCount = 5;
        const int critterVarieties = 5;

        public IEnumerable<CritterBrains.CritterBrain> GetCritterBrains()
        {
            // I bet there's a better way to do this. :-)
            for (int i = 0; i < totalCritterCount; i++)
            {
                switch (i % critterVarieties)
                {
                    case 0: yield return new DemoCritterBrain1(); break;
                    case 1: yield return new DemoCritterBrain2(); break;
                    case 2: yield return new DemoCritterBrain3(); break;
                    case 3: yield return DemoCritterBrain4.CreateCritterBrain4(); break;
                    case 4: yield return new DemoCritterBrain5(); break;
                }
            }
        }

    }
}
