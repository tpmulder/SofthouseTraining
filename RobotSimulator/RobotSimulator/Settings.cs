using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static bool Exit { get; set; }
        public static Direction Facing { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Exit = false;
            Facing = Direction.north;
        }
    }
}
