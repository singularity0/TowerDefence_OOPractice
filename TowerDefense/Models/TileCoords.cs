using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Utils;

namespace TowerDefense.Models
{
    public struct TileCoords
    {
        private int x;
        private int y;

        public TileCoords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X 
        { 
            get 
            { 
                return this.x; 
            } 
            set 
            {
                if (Helpers.matrixLvl1.GetLength(0) < value)
                {
                    throw new Exceptions(Exceptions.OutsideOfTheMatrix);
                }
                this.x = value; 
            } 
        }
        public int Y { get { return this.y; } set { this.y = value; } }
        
    }
}
