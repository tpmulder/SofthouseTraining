using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Exercise4
    {
        public static void Program23()
        {
            Console.WriteLine("ForLoop3 - A program that makes a pattern like a pyramid\n");

            string n = Console.ReadLine();

            while (!Utilities.Validation(n, 1, 9))
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
                    Console.Write(j);                    
                }
                for (int y = (i - 1); y >= 1; y--)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            for (int i = x - 1; i >= 0; i--)
            {
                for (int k = x; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int y = (i - 1); y >= 1; y--)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nNice pattern!\n");
        }
    }
}
