using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Interfaces;
using TowerDefense.Utils;

namespace TowerDefense
{
    /// <summary>
    /// Tiles are used for passing the positions of the objects in the game
    /// </summary>
    public class Tile : ITile
    {
        
        protected bool tileInUse = false; // Is tile in use (eg. it has a building on it)?

        protected bool selected = false; // showing if this tile is selected by the mouse

        public bool InUse
        {
            get { return this.tileInUse; }
            set { this.tileInUse = value; }
        }

        public bool IsSelected  
        {
            get { return this.selected; }
            set { this.selected = value; }
        }

        public int X { get; set; }
        public int Y { get; set; }

        public Tile(int x, int y)  
        {
            this.InUse = true;
            this.X = x;
            this.Y = y;
        }

        public float? ClearTileArea(bool destroying = false) //destroying buidlings/towers (for ex. to earn some money)
        {
            this.InUse = false;
            if (destroying)
            {
                return Helpers.moneyRegainedPerTowerDestroyed;
            }
            else
            {
                return null;
            }

            
        }
    }
}
