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
            int n = 0;

            Console.WriteLine("ForLoop3 - A program that makes a pattern like a pyramid with asterisk\n");
            Console.Write("Number of lines: ");

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Please input an int: ");
            }
            Console.WriteLine("A {0} lines pattern: ", n);

            for (int i = 1; i <= n; i++)
            {
                for (int k = n; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            Console.ReadLine(); // Dit is zodat je in het programma blijft nadat je alles hebt ingevoerd
        }
    }
}
