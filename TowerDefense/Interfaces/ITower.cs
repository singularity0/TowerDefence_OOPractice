using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Interfaces
{
    public interface ITower
    {
        float Damage { get; }

        float Range{ get; }

        int Level { get; }

        int Cost { get; }

        void LevelUP();
    }
}
