using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator2
{
    class Settings
    {
        public static bool IsRunning { get; set; }
        public static int Speed { get; set; }

        public Settings()
        {
            Speed = 5;
            IsRunning = true;
        }
    }
}
