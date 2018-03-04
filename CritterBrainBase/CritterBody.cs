using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

// CritterBody is a thin wrapper around the ICritter interface for use by critter brains.

namespace CritterBrainBase
{
    public class CritterBody
    {
        ICritter _body;

        public CritterBody(ICritter body)
        {
            _body = body;
        }

        /// <summary>
        /// Start the critter moving at the specified speed
        /// </summary>
        /// <param name="speed"></param>

        public void Move(int speed)
        {
            _body.MoveCritter(speed);
        }

        /// <summary>
        /// Stop the critter moving
        /// </summary>

        public void Stop()
        {
            _body.StopCritter();
        }

        /// <summary>
        /// Returns the current speed of the critter
        /// </summary>

        public int Speed
        {
            get
            {
                return _body.Speed;
            }
        }

        /// <summary>
        /// Set/Get the direction the critter is to move
        /// </summary>

        public int Direction
        {
            set
            {
                _body.Direction = value;
            }
            get
            {
                return _body.Direction;
            }
        }

        /// <summary>
        /// Get the current energy value of the critter
        /// </summary>

        public int Energy
        {
            get
            {
                return _body.Energy;
            }
        }

        /// <summary>
        /// Get the current age of the critter
        /// </summary>

        public int Age
        {
            get
            {
                return _body.Age;
            }
        }

        /// <summary>
        /// Get the direction to the specified x, y position
        /// </summary>

        public int GetDirectionTo(int x, int y)
        {
            return _body.GetDirectionTo(x, y);
        }

        /// <summary>
        /// Returns the Rectangle representing the goal to be reached.
        /// </summary>

        public Rectangle GetDestination()
        {
            return _body.GetDestination();
        }

        /// <summary>
        /// Is terrain blocking the direct route to the specified x, y coordinates
        /// </summary>

        public bool IsTerrainBlockingRouteTo(int x, int y)
        {
            return _body.IsTerrainBlockingRouteTo(x, y);
        }

    }
}
