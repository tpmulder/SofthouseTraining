using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class RobotSimulator
    {
        public static void Program25()
        {
            Console.WriteLine("Welcome to the robot simulator");
            Console.Write("Please enter your command:");

            int Xpos = 0;
            int Ypos = 0;
            int Facing = 0;

            string x = Console.ReadLine().ToLower();
            string y = "bcdefghijkmnopqstuvw ";
            char[] invalid = y.ToCharArray();
            char[] input = x.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < invalid.Length; j++)
                {
                    while (input[i] == invalid[j] || x == "")
                    {
                        Console.WriteLine("Please give a valid command");
                        Console.ReadLine();
                    }
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    switch (Facing)
                    {
                        case 0:
                            Ypos++;
                            break;
                        case 1:
                            Xpos++;
                            break;
                        case 2:
                            Ypos--;
                            break;
                        case 3:
                            Xpos--;
                            break;
                    }
                }
                if (input[i] == 'r')
                {
                    if (Facing == 3)
                    {
                        Facing = 0;
                    }
                    else
                    {
                        Facing++;
                    }
                }
                if (input[i] == 'l')
                {
                    if (Facing == 0)
                    {
                        Facing = 3;
                    }
                    else
                    {
                        Facing--;
                    }
                }
            }
            Console.WriteLine("X-position = {0}\nY-position = {1}\nFacing in direction {2}", Xpos, Ypos, Facing);
        }       
    }
}
