using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Interfaces;

namespace TowerDefense.Models
{
    public class Tower : GameObject, ITower
    {
        
        private float baseDamage;
        private float range;
        private double fireTimer = 0;
        private int level;
        private int cost;
        private IList<IEnemy> targets;
        //private Tile currentTile;
        private TileCoords coords; //keeping track of current location

        public Tower(int X, int Y, int level = 1, int width = 1, int height = 1)
            : base(1, 0, 0, width, height)
        {
            //this.AvailablePath = Helpers.enemyPathLvl1;   //TODO: tower should check if the Tile is vacant;
            this.coords = new TileCoords(0, 0);
            this.Cost = 85;
            this.Level = level;
            this.targets = new List<IEnemy>();
            //currentTile.X = X;   
            //currentTile.Y = Y;    
            coords.X = X;
            coords.Y = Y;
        }

        public int UpgradeCost { get { return (int)(this.cost * (1 + ((float)this.Level / 5))); } }

        public float Damage { get { return baseDamage * Level; } }

        public float Range { get { return this.range; } set { this.range = value; } }

        public int Level { get { return this.level; } set { this.level = value; } }

        public int Cost { get { return this.cost; } set { this.cost = value; } }


        internal virtual void LevelUP()
        {
            this.Level++;
        }



        void ITower.LevelUP()
        {
            this.Level += 1;
        }
    }
}
