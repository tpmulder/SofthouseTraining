using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Basic2
    {
        public static void Program2() 
        {
            int n;
            List<int> list = new List<int>();

            Console.WriteLine("Basic2 - A program that takes three numbers as input to calculate and print the output of a equation.\n");

            for (int i = 1; i < 3 + 1; i++)
            {
                Console.Write("Enter element {0}: ", i);

                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Please Enter an int: ");
                }
                list.Add(n);
            }
            int result1 = (list[0] + list[1]) * list[2];
            int result2 = (list[0] * list[1]) + (list[1] * list[2]);

            int x = list[0];
            int y = list[1];
            int z = list[2];

            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, ((x + y) * z) is {3} and ((x * y) + (y * z)) is {4}", x, y, z, result1, result2);
        }
    }
}
