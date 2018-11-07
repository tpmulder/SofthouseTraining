using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator2
{
    class RobotBox
    {
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool Forward { get; set; }

        public RobotBox(int Xpos, int Ypos, int Height, int Width)
        {
            Forward = true;
        }
    }
}
