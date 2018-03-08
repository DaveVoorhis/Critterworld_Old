using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CritterWorld
{
    public class Configuration
    {
        int foodDumps;
        int foodDecayTime;
        int poopEvaporateTime;
        bool autoNewFoodDump;
        int critterEnergyGainedPerFeed;
        int critterEnergyLostPerDefilement;
        int critterEnergyWhenBorn;
        string worldFileName;

        public Configuration()
        {
            ResetToBuiltInDefaults();
        }

        public void EditConfiguration()
        {
            // Code to open a dialog box to edit the configuration options goes here.
            // Replace the code below
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Background Image";
            openFileDialog.Filter = "PNG Files|*.png|JPEG Files|*.jpg|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                worldFileName = openFileDialog.FileName;

        }

        public void ResetToBuiltInDefaults()
        {
            foodDumps = 6;
            foodDecayTime = 30;
            poopEvaporateTime = 10;
            autoNewFoodDump = true;
            critterEnergyGainedPerFeed = 10;
            critterEnergyLostPerDefilement = 20;
            critterEnergyWhenBorn = 50;
            worldFileName = "BackgroundBase.png";
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

        public bool AutoNewFoodDump 
        {
            get
            {
                return autoNewFoodDump;
            }
            set
            {
                autoNewFoodDump = value;
            }
        }

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

        public string WorldFileName
        {
            get
            {
                return worldFileName;
            }
            set
            {
                worldFileName = value;
            }
        }        
        
    }
}
