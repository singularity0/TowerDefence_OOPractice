using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class StartUp
    {
        static void Main()
        {
            var map = new Map();
            var enemy = new Ogre(100, 1, 12);
            Console.WriteLine(enemy.Health);
            enemy.TakeHits();
            Console.WriteLine(enemy.Health);
            Console.WriteLine(enemy.IsAlive);
            for (int i = 0; i < 3; i++)
            {
                enemy.TakeHits();
            }
            Console.WriteLine(enemy.Health);
            Console.WriteLine(enemy.IsAlive);

            //Console.WriteLine(enemy.CurrentTile.X);
            //Console.WriteLine(enemy.CurrentTile.Y);
            //enemy.Move();
            //Console.WriteLine(enemy.CurrentTile.X);
            //Console.WriteLine(enemy.CurrentTile.Y);


        }
    }
}
