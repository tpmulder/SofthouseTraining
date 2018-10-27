using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Basic7
    {
        public static void Program7()
        {
            int x;

            Console.WriteLine("Basic7 - A program that displays a given int to its equivalent binary form\n");
            Console.Write("Input a number: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Please Enter an int: ");
            }
            string binary = Convert.ToString(x, 2);
            Console.WriteLine("Binary:  {0}", binary);
        }
    }
}
