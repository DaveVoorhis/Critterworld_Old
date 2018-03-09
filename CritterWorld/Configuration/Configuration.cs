using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CritterWorld
{
    public class Configuration
    {
        int foodDumps;
        int foodDecayTime;
        int poopEvaporateTime;
        int critterEnergyGainedPerFeed;
        int critterEnergyLostPerDefilement;
        int critterEnergyWhenBorn;

        public Configuration()
        {
            ResetToBuiltInDefaults();
        }

        public void EditConfiguration()
        {
            ConfigForm configForm = new ConfigForm(this);
            configForm.ShowDialog();
        }

        public void ResetToBuiltInDefaults()
        {
            foodDumps = 6;
            foodDecayTime = 30;
            poopEvaporateTime = 10;
            AutoNewFoodDump = true;
            critterEnergyGainedPerFeed = 10;
            critterEnergyLostPerDefilement = 20;
            critterEnergyWhenBorn = 50;
            WorldFileName = "BackgroundBase.png";
        }

        public int FoodDumps 
        {
            get
            {
                return foodDumps;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid number of food dumps: " + value.ToString());
                }
                else
                {
                    foodDumps = value;
                }
            } 
        }

        public bool AutoNewFoodDump { get; set; }

        public int FoodDecayTime
        {
            get
            {
                return foodDecayTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid food decay time: " + value.ToString());
                }
                else
                {
                    foodDecayTime = value;
                }
            }
        }

        public int PoopEvaporateTime
        {
            get
            {
                return poopEvaporateTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid poop evaporate time: " + value.ToString());
                }
                else
                {
                    poopEvaporateTime = value;
                }
            }
        }

        public int CritterEnergyWhenBorn
        {
            get
            {
                return critterEnergyWhenBorn;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid value for critter energy when born: " + value.ToString());
                }
                else
                {
                    critterEnergyWhenBorn = value;
                }
            }
        }

        public int CritterEnergyPerFeed
        {
            get
            {
                return critterEnergyGainedPerFeed;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid value for energy gained by a critter per feed: " + value.ToString());
                }
                else
                {
                    critterEnergyGainedPerFeed = value;
                }
            }
        }

        public int CritterEnergyPerDefilement
        {
            get
            {
                return critterEnergyLostPerDefilement;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid value for energy lost by a critter for stepping in poop: " + value.ToString());
                }
                else
                {
                    critterEnergyLostPerDefilement = value;
                }
            }
        }

        public string WorldFileName { get; set; }

    }
}
