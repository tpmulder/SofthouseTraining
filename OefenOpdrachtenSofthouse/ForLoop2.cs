using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class ForLoop2
    {
        public static void Program10()
        {
            int n = 0;
            bool validation = false;
            Console.WriteLine("ForLoop2 - A program that makes a pattern with a for loop");
            Console.Write("Amount of lines: ");
            while (validation == false)
            {
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Please Enter a number between 0 and 10: ");
                }
                if (n > 0 && n < 10)
                {
                    Console.WriteLine("Amount of lines: {0}", n);
                    validation = true;
                }
                else
                {
                    Console.Write("Please Enter a number between 0 and 10: ");
                }
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
