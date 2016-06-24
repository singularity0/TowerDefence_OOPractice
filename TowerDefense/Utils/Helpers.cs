using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Utils
{
    public static class Helpers
    {
        public const int SPEEDDOWNPOINTS = 20;  //points to speed down the enemy with
        public static int takeHitsFactor = 20; //user takes this many points from enemy on every hit

        public static bool[,] matrixLvl1 = new bool[5, 10] {
                {true, false, false, false, false, false, false, false, false, false},
                {true, false, false, false, false, false, false, false, false, false},
                {true, true, false, false, false, false, false, true, true, true},
                {false, true, true, true, true, false, false, true, false, false},
                {false, false, false, false, true, true, true, true, false, false}};

        public static List<Tile> enemyPathLvl1 = new List<Tile>() {
                    new Tile(0,0),
                    new Tile( 1,0),
                    new Tile( 2,0),
                    new Tile( 2,1),
                    new Tile( 3,1),
                    new Tile( 3,2),
                    new Tile( 3,3),
                    new Tile( 3,4),
                    new Tile( 4,4),
                    new Tile( 4,5),
                    new Tile( 4,6),
                    new Tile( 4,7),
                    new Tile( 3,7),
                    new Tile( 2,7),
                    new Tile( 2,8),
                    new Tile( 2,9)
            };

        public static int moneyRegainedPerTowerDestroyed = 100; 
    }
}
