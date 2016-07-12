using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Interfaces;
using TowerDefense.Models;
using TowerDefense.Utils;

namespace TowerDefense.Factory
{
    public class TowerDefenceFactory : ITowerDefenceFactory
    {
        public ITile CreateTile(int x, int y)
        {
            return new Tile(x, y);
        }

        public IEnemy CreateOgre(int health, int level, float speed)
        {
            return new Ogre(health, level, speed);
        }

        public IEnemy CreateGhost(int health, int level, float speed)
        {
            return new Ghost(health, level, speed);
        }

        public IUser CreateUser(string name, LevelType level, string password = null)
        {
            return new User(name, password = null, level = LevelType.Easy);
        }

        public ITower CreateBasicTower(int X, int Y, int level = 1, int width = 1, int height = 1)
        {
            return new BasicTower(X, Y, level, width, height);
        }

        public ITower CreateArcherTower(int X, int Y, int level = 1, int width = 1, int height = 1)
        {
            return new ArcherTower(X, Y, level, width, height);
        }

        public ITower CreateCannonTower(int X, int Y, int level = 1, int width = 1, int height = 1)
        {
            return new CannonTower(X, Y, level, width, height);
        }


    }
}
