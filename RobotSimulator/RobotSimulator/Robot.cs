﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    class Robot
    {
        public enum Direction
        {
            north,
            east,
            south,
            west
        }

        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public Direction Facing { get; set; }

        public Robot()
        {
            Xpos = 0;
            Ypos = 0;
            Facing = Direction.east;
        }
    }
}
