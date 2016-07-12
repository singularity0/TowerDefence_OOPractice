using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Utils;

namespace TowerDefense
{
    public sealed class Map
    {
        private bool[,] matrix;

        private List<Tile> enemyPath; 

        public List<Tile> EnemyPath { get { return this.enemyPath; } }

        public Map()
        {
            this.matrix = Helpers.matrixLvl1; //the only available level map
            this.enemyPath = Helpers.enemyPathLvl1; //the only available enemy path
            
        }
    }
}
