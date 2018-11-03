using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    public enum Direction
    {
        north,
        east,
        south,
        west
    }

    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static bool IsRunning { get; set; }
        public static Direction Facing { get; set; }
        public static bool Move { get; set; }
        public static int Speed { get; set; }

        public Settings()
        {
            Speed = 5;
            Width = 16;
            Height = 16;
            IsRunning = false;
            Facing = Direction.east;
        }
    }
}
