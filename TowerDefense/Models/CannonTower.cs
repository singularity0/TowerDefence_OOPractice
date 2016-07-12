using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Models
{
    public class CannonTower : Tower
    {
        private int numberOfCannonBallsAvailable = 60;
        public CannonTower(int X, int Y, int level = 1, int width = 1, int height = 1)
            : base(X, Y, level, width, height)
        {

        }

        public int NumberCannonBallsAvail
        {
            get 
            {
                return this.numberOfCannonBallsAvailable;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("cannon balls cannot be less than 0");
                }
                if (value > 180)
	            {
		            value = 180;
	            }
                this.numberOfCannonBallsAvailable = value;
            }
        }
    }
}
