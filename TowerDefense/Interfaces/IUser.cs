using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Models;

namespace TowerDefense.Interfaces
{
    public interface IUser
    {
        string Username { get; }

        string Password { get; }

        void ShootEnemies(IEnemy enemy);



    }
}
