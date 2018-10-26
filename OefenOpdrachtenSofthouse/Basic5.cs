using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Basic5
    {
        public static void Program5()
        {
            int n = 0;

            Console.WriteLine("Basic5 - A program that solves a function");
            Console.WriteLine("Equasion to solve: x = y² - 2y +1");
            Console.WriteLine("The program solves the equasion for y - 2 to y + 2");
            Console.Write("Input y: ");

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Please Enter an int: ");
            }

            for (int y = n - 2; y <= n + 2; y++)
            {
                int x = y * y - 2 * y + 1;
                Console.WriteLine("y = {0} ; x=({0})² - 2*({0}) +1 = {1}",
                    y, x);
            }
        }
    }
}
