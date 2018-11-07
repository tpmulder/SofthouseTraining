using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator2
{
    public class Robot
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
        public int Height { get; set; }
        public int Width { get; set; }
        public Direction Facing { get; set; }

        public Robot()
        {
            Xpos = 0;
            Ypos = 0;
            Height = 15;
            Width = 15;
            Facing = Direction.east;
        }
    }
}
