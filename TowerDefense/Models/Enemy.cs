using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Interfaces;
using TowerDefense.Models;
using TowerDefense.Utils;

namespace TowerDefense
{
    public abstract class Enemy : GameObject, IEnemy
    {
        protected int enemyHealth;
        protected int enemyLevel;
        protected float enemySpeed;
        protected bool slownessMagic;
        Tile currentTile = new Tile(0, 0);   //keeping track of the current position by knowing which Tile it is on;
        int currentPosInAvailList; //track the current index of the Tile in the available provided list of Tiles
        protected bool isAlive;  //indicates if the enemy is alive



        public Enemy(int health, int level, float speed, int width = 1, int height = 1 ): base(1, 0, 0, width, height)
        {
            this.isAlive = true;
            this.enemyHealth = health;
            this.enemyLevel = level;
            this.enemySpeed = speed;
            this.slownessMagic = false; //by default the enemy is not under slowness magic
            this.AvailablePath = Helpers.enemyPathLvl1;   //enemy should know its available path
            currentTile.X = this.AvailablePath[0].X;    //keeping track of current location
            currentTile.Y = this.AvailablePath[0].Y;    //keeping track of current location
        }

        public List<Tile> AvailablePath { get; set; }

        public bool IsAlive { get { return this.isAlive; } set { this.isAlive = value; } }



        // Tracks the tile/position the Enemy is currently on
        public Tile CurrentTile
        {
            get { return currentTile; }
            set
            {
                this.currentTile = value;
            }
        }

        //health of the enemy
        public int Health
        {
            get
            {
                if (this.enemyHealth <= 0)
                {
                    this.enemyHealth = 0;
                    this.isAlive = false;
                }
                return this.enemyHealth;
            }
            set
            {
                
                this.enemyHealth = value;
            }
        }

        //higher level enemies are more difficult for killing
        public int Level
        {
            get { return enemyLevel; }
        }

        //shows if the enemy is under some kond of magic slowing it down
        public bool MagicOngoing
        {
            get { return this.slownessMagic; }
            set
                {
                    if(value == true)
                    {
                        this.Speed -= Helpers.SPEEDDOWNPOINTS;
                    }
                    this.slownessMagic = value;
                }
        }

        //how fast is the enemy
        public float Speed
        {
            get
            {
                return this.Speed;
            }
            set
            {
                this.enemySpeed = value;
            }
        }


        public void Die()
        {
            this.isAlive = false;
        }

        
        public void Move()
        {
            if (!this.IsAlive)
            {
                return;
            }
            currentPosInAvailList++;
            CurrentTile.X = GetNextAvailableSlot().X;
            CurrentTile.Y = GetNextAvailableSlot().Y;
        }

        public Tile GetNextAvailableSlot( ) //check for the next slot available for the enemy
        {
            return new Tile(AvailablePath[currentPosInAvailList].X, AvailablePath[currentPosInAvailList].Y);
        }

        public override string ToString()
        {
            return string.Format("Enemy Parent of All Parents");
        }



    }
}
