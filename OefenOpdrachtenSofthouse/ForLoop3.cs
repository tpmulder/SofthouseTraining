using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class ForLoop3
    {
        public static void Program11()
        {
            Console.WriteLine("ForLoop3 - A program that makes a pattern like a pyramid with asterisk\n");
            Console.Write("Number of lines (Max 59) : ");
            string n = Console.ReadLine();

            while (!Utilities.Validation(n, 1, 59))
            {
                Console.WriteLine("Please enter a valid number");
                n = Console.ReadLine();
            }

            int x = int.Parse(n);

            for (int i = 1; i <= x; i++)
            {
                for (int k = x; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nNice pattern!\n");
        }
    }
}
