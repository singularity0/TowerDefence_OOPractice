using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Utils
{
    public class Exceptions : ApplicationException
    {
        public const string WrongUsernameExceptionMessage = "Wrong username, please enter your username with more that 2 symbols!";
        public const string EnemyTypeExceptionMessage = "You must specify what kind of enemy item you want to create!";

        public Exceptions(string message)
            : base(message)
        {
        }
    }

}
