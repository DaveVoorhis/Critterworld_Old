using System;
using System.Drawing;
using System.Collections.Generic;

namespace Sprites
{
	/// <summary>
	/// A collection of sprites.
    /// class by Sasha Djurovic, djurovic@nyc.rr.com
    /// see http://www.codeproject.com/KB/GDI-plus/sprites.aspx
    /// modified by DMVoorhis, d.voorhis@derby.ac.uk
    /// </summary>
	public class SpriteCollection : List<Sprite>
	{
		private List<Sprite> sortedByZ = new List<Sprite>();

        public List<Sprite> SortedByZ
        {
            get 
            { 
                return sortedByZ; 
            }
        }

		public new void Add(Sprite sprite)
		{
			SortedByZ.Insert(Count, sprite);
            base.Add(sprite);
		}
	}
}
