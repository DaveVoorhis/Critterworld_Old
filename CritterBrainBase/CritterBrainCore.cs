using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CritterBrainBase
{
    public class CritterBrainCore
    {
        string _name = "Unnamed Critter";
        string _creator = "Creator not specified";
        Image[] _images = null;
        ICritter _critter = null;
        CritterBody _critterBody = null;

        public CritterBrainCore(string name, string creator) : this(name, creator, null)
        {
        }

        public CritterBrainCore(string name, string creator, Image[] images)
        {
            _name = name;
            _creator = creator;
            _images = images;
        }
        
        public virtual void Birth()
        {
        }

        public virtual void Think()
        {
        }

        public virtual void NotifyBumpedObject(int x, int y)
        {
        }

        public virtual void NotifyBumpedCritter(OtherCritter other)
        {
        }

        public virtual void NotifyBlockedByTerrain()
        {
        }

        public virtual void NotifyEaten()
        {
        }

        public void NotifyDefiled()
        {
        }

        public virtual void NotifyCloseToFood(int x, int y)
        {
        }

        public virtual void NotifyCloseToCritter(OtherCritter otherCritter)
        {
        }

        // Non-virtual methods/properties. These are used to hide some of the underlying implementation
        // of CritterWorld.

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Creator
        {
            get
            {
                return _creator;
            }
        }

        public Image[] Images
        {
            get
            {
                return _images;
            }
        }

        public ICritter Body
        {
            set
            {
                _critter = value;
                _critterBody = new CritterBody(_critter);
            }
        }

        public CritterBody Critter
        {
            get
            {
                return _critterBody;
            }
        }

        public void NotifyBumped(IWorldObject other)
        {
            if (other is IOtherCritter)
            {
                NotifyBumpedCritter(new OtherCritter((IOtherCritter)other, _critter));
            }
            else
            {
                NotifyBumpedObject(other.X, other.Y);
            }
        }

        public void NotifyCloseToFood(IWorldObject food)
        {
            NotifyCloseToFood(food.X, food.Y);
        }

        public void NotifyCloseToCritter(IOtherCritter otherCritter)
        {
            NotifyCloseToCritter(new OtherCritter((IOtherCritter)otherCritter, _critter));
        }

    }
}
