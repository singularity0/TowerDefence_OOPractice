using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Interfaces
{
    public interface ITile
    {
        bool InUse { get; set; }

        bool IsSelected { get; set; }

    }
}
