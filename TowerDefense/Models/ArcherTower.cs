using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Models
{
    public class ArcherTower : Tower
    {
        private int numberOfArchesavailable = 140;
        public ArcherTower(int X, int Y, int level = 1, int width = 1, int height = 1)
            : base(X, Y, level, width, height)
        {

        }

        public int NumberOfArchesAvail
        {
            get 
            {
                return this.numberOfArchesavailable;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("arches cannot be less than 0");
                }
                if (value > 200)
	            {
		            value = 200;
	            }
                this.numberOfArchesavailable = value;
            }
        }
    }
}
