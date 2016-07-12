using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Utils;

namespace TowerDefense.Interfaces
{
    public interface ITowerDefenceFactory
    {

        IUser CreateUser(string name, LevelType level, string password = null);

        ITile CreateTile(int x, int y);

        IEnemy CreateOgre(int health, int level, float speed);

        IEnemy CreateGhost(int health, int level, float speed);

        ITower CreateBasicTower(int X, int Y, int level = 1, int width = 1, int height = 1);

        ITower CreateArcherTower(int X, int Y, int level = 1, int width = 1, int height = 1);

        ITower CreateCannonTower(int X, int Y, int level = 1, int width = 1, int height = 1);

    }
}
