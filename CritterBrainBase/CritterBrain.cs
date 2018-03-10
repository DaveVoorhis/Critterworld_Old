using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace CritterBrains
{
    /// <summary>
    /// You must inherit from this class to create your own Critter brain.
    /// </summary>
    public class CritterBrain
    {
        ICritter _critter = null;

        /// <summary>
        /// Critter brain constructor. Use default images.
        /// </summary>
        /// <param name="name">Critter brain name.</param>
        /// <param name="creator">Critter brain author.</param>
        public CritterBrain(string name, string creator) : this(name, creator, null)
        {
        }

        /// <summary>
        /// Critter brain constructor. Use your own images. They must be 15x15 pixels.
        /// </summary>
        /// <param name="name">Critter brain name.</param>
        /// <param name="creator">Critter brain author.</param>
        /// <param name="images">Array of images.</param>
        public CritterBrain(string name, string creator, Image[] images)
        {
            Name = name;
            Creator = creator;
            Images = images;
        }
        
        /// <summary>
        /// Override to be notified when a Critter is born into the World using this CritterBrain.
        /// </summary>
        public virtual void Birth()
        {
        }

        /// <summary>
        /// Override to be notified when it's time to think, i.e., plan actions.
        /// </summary>
        public virtual void Think()
        {
        }

        /// <summary>
        /// Override to be notified when we've bumped into something.
        /// </summary>
        /// <param name="thing">The thing into which we've bumped.</param>
        public virtual void NotifyBumpedObject(IWorldObject thing)
        {
        }

        /// <summary>
        /// Override to be notified when we've bumped into a critter.
        /// </summary>
        /// <param name="other">Reference to the other Critter.</param>
        public virtual void NotifyBumpedCritter(OtherCritter other)
        {
        }

        /// <summary>
        /// Override to be notified when we're blocked by terrain.
        /// </summary>
        public virtual void NotifyBlockedByTerrain()
        {
        }

        /// <summary>
        /// Override to be notified when we've eaten food.
        /// </summary>
        public virtual void NotifyEaten()
        {
        }

        /// <summary>
        /// Override to be notified when we've stepped in poop.
        /// </summary>
        public void NotifyDefiled()
        {
        }

        /// <summary>
        /// Override to be notified when we're near food.
        /// </summary>
        /// <param name="x">Horizontal coordinate of food.</param>
        /// <param name="y">Vertical coordinate of food.</param>
        public virtual void NotifyCloseToFood(int x, int y)
        {
        }

        /// <summary>
        /// Override to be notified when we're near another critter.
        /// </summary>
        /// <param name="otherCritter">Reference to other critter.</param>
        public virtual void NotifyCloseToCritter(OtherCritter otherCritter)
        {
        }

        /// <summary>
        /// Override to be notified when we're near poop.
        /// </summary>
        /// <param name="x">Horizontal coordinate of poop.</param>
        /// <param name="y">Vertical coordinate of poop.</param>
        public virtual void NotifyCloseToPoop(int x, int y)
        {
        }

        // Non-virtual methods/properties. These are used to hide some of the underlying implementation
        // of CritterWorld.

        /// <summary>
        /// Get CritterBody controlled by this CritterBrain. (Used to Set internally, too.)
        /// </summary>
        public CritterBody Critter { get; private set; } = null;

        /// <summary>
        /// Get the Edit form for this CritterBrain.
        /// </summary>
        public virtual Form Form { get; }

        /// <summary>
        /// Get the name of this CritterBrain.
        /// </summary>
        public string Name { get; } = "Unnamed Critter";

        /// <summary>
        /// Get the author of this CritterBrain.
        /// </summary>
        public string Creator { get; } = "Creator not specified";

        /// <summary>
        /// Get the images associated with this CritterBrain.
        /// </summary>
        public Image[] Images { get; } = null;

        /// <summary>
        /// Set the Critter body managed by this Brain. For use only by CritterWorld internals.
        /// </summary>
        public ICritter Body
        {
            set
            {
                Me = value;
                Critter = new CritterBody(Me);
            }
        }

        private ICritter Me { get => _critter; set => _critter = value; }

        public void NotifyBumped(IWorldObject other)
        {
            if (other is IOtherCritter)
            {
                NotifyBumpedCritter(new OtherCritter((IOtherCritter)other, Me));
            }
            else
            {
                NotifyBumpedObject(other);
            }
        }

        public void NotifyCloseToFood(IWorldObject food)
        {
            NotifyCloseToFood(food.X, food.Y);
        }

        public void NotifyCloseToCritter(IOtherCritter otherCritter)
        {
            NotifyCloseToCritter(new OtherCritter((IOtherCritter)otherCritter, Me));
        }

    }
}
