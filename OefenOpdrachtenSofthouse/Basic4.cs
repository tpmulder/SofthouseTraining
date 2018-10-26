using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Basic4
    {
        public static void Program4()
        {
            int n;
            int value = 20;
            List<int> list = new List<int>();

            Console.WriteLine("Basic4 - A program that checks the nearest value of two given integers.\n");

            Console.WriteLine("Input magic number");
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Please Enter an int: ");
            }

            Console.WriteLine("Magic number: {0}", value);

            for (int i = 1; i < 2 + 1; i++)
            {
                Console.Write("Enter number {0}: ", i);

                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Please Enter an int: ");
                }
                list.Add(n);
            }

            int x = list[0];
            int y = list[1];

            int abstractX = x - value;
            int abstractY = y - value;

            int result = 0;

            if (Math.Abs(x) == Math.Abs(y))
            {
                result = 0;
            }
            else if ((x >= value || y >= value) && x < y)
            {
                result = x;
            }
            else if ((x >= value || y >= value) && x < y)
            {
                result = y;
            }
            else if (abstractX < abstractY && Math.Abs(x) != Math.Abs(y))
            {
                result = y;
            }
            else if ((abstractX < 0 || abstractY < 0) && (abstractX > abstractY && Math.Abs(x) != Math.Abs(y)))
            {
                result = x;
            }

            Console.WriteLine("The closest value of {0} is: {1}", value, result);
        }
    }
}