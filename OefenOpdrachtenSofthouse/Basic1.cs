using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Basic1
    {
        public static void Program1()
        {
            int x;
            List<int> list = new List<int>();

            Console.WriteLine("Basic1 - A program that takes four numbers as input to calculate and print the average.\n");

            for (int i = 1; i < 5 + 1; i++)
            {
                Console.Write("Enter element {0}: ", i);

                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Please Enter an int: ");
                }
                list.Add(x);
            }

            int[] array = list.ToArray();

            int avg = Convert.ToInt32(array.Average());

            Console.WriteLine("Your list it\'s content: ");
            list.ForEach(Console.WriteLine);
            Console.WriteLine("The average of your list is: {0}", avg);
        }
    }
}
