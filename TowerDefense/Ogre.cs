﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    public class Ogre : Enemy
    {
        public override int PointsForBeastKiling {get { return 100; }}

        
        public Ogre(int health, int level, float speed) : base(health, level, speed)
        {

        }

        public Ogre() : base(100, 1, 10) //hardcodes values for quick initialization
        {

        }

        public override void DestroyPoints()
        {
            User.Points += this.PointsForBeastKiling;
        }
    }
}
