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
    public class User : IUser
    {
        private int points;
        private const int startMoney = 100;
        private const int startHealth = 100;

        private readonly string name;
        private int money;
        private int health;
        private LevelType level;
        private string password;
        private IList<ITower> towers;
        private int pointsForBeastKiling = 50;  //if we work on abstract level we get some mean value

        public User(string name, string password = null, LevelType level = LevelType.Easy)
        {
            this.Points = points;
            if (name.Length < 3)
            {
                throw new Exceptions(Exceptions.WrongUsernameExceptionMessage);
            }
            this.name = name;
            this.Money = startMoney;
            this.Health = startHealth;
            this.Level = level;
            this.password = password;
            this.towers = new List<ITower>(); 
            //this.PausedGame = false;
        }

        public int Points { get { return this.points; } set { this.points = value; } }

        public string Username
        {
            get { return this.name; }
        }

        public string Password
        {
            get { return this.password; }
        }

        public IList<ITower> Towers
        {
            get { return this.towers; }
            set { this.towers = value; }
        }    

        void IUser.ShootEnemies(IEnemy enemy)
        {
            this.pointsForBeastKiling += pointsForBeastKiling;
            enemy.Health -= Helpers.HitsFactor/ enemy.Level;
        }


        public LevelType Level
        {
            get { return level; }
            set { this.level = value; }
        }

        public int Money
        {
            get { return this.money; }
            private set
            {
                this.money = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (health < 0)
                {
                    throw new ArgumentOutOfRangeException("Not enough health!");
                }
                this.health = value;
            }
        }

        public void AddTower(ITower tower)
        {
            this.towers.Add(tower);
        }

        public void DestroyPoints()
        {
            this.Points += Helpers.moneyRegainedPerTowerDestroyed;
        }

        public void BuyTower(int amount)
        {
            if (this.money < amount)
            {
                throw new ArgumentOutOfRangeException("Not enough money!");
            }
            this.Money -= amount;
        }
        
        public void PrintTowers()
        {
            var builder = new StringBuilder();
            if (this.Towers.Count == 0)
            {
                Console.WriteLine("No towers currently");
            }
            else
            {
                foreach (var tower in this.Towers)
                {
                    builder.AppendLine(string.Format("Tower Type:{0}; Damage:{1}", tower.GetType().Name, tower.Damage));
                }
            }
        }
    }
}
