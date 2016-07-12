using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Models
{
    class BasicTower : Tower
    {

        public BasicTower(int X, int Y, int level = 1, int width = 1, int height = 1)
            : base(X, Y, level, width, height)
        {

        }

    }
}
