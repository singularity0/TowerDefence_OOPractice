using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Engine;
using TowerDefense.Factory;
using TowerDefense.Interfaces;

namespace TowerDefense
{
    class StartUp
    {
        static void Main()
        {
            //TowerDefenceEngine.Instance.Start();
            var map = new Map();
            //var enemy = new Ogre(100, 1, 12);
            IEnemy someEnemy = new TowerDefenceFactory().CreateOgre(110, 2, 123);
            IEnemy anotherEnemy = new TowerDefenceFactory().CreateGhost(88, 1, 123);

            var enemies = new List<IEnemy>() { someEnemy, anotherEnemy };
            foreach (var enemy in enemies)
            {
                Console.WriteLine(enemy.ToString());
            }

            IUser myUser = new TowerDefenceFactory().CreateUser("Nindja", Utils.LevelType.Ninja, "strong_pass");
            IUser myUseBoom = new TowerDefenceFactory().CreateUser("N", Utils.LevelType.Ninja, "strong_pass");




  


        }
    }
}
