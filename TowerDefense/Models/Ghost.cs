using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    public class Ghost : Enemy
    {
        
        public Ghost(int health, int level, float speed) : base(health, level, speed)
        {
          
        }

        public Ghost() : base(50, 1, 20)   //hardcodes values for quick initialization
        {

        }

        public override string ToString()
        {
            return base.ToString() + string.Format("--> I am a {0} child ", this.GetType().Name);
        }
        

    }
}
