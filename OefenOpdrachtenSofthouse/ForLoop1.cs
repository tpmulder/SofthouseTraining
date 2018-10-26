using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class ForLoop1
    {
        public static void Program9()

        {
            int j;
            int sum = 0;

            Console.WriteLine("ForLoop1 - A program that sums up a given amount of the first natural numbers starting from 1\n");
            Console.Write("Amount of numbers to sum up: ");

            while (!int.TryParse(Console.ReadLine(), out j))
            {
                Console.Write("Please Enter an int: ");
            }

            Console.WriteLine("The first {0} natural numbers are : ");
            for (int i = 1; i <= j; i++)
            {
                sum = sum + j;
                Console.Write("{0}\n", i);
            }
            Console.WriteLine("\nThe Sum is : {0}", sum);
        }
    }
}
