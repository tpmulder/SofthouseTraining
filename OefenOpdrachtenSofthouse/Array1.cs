using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Array1
    {
        public static void Program12()
        {
            List<int> list = new List<int>();

            for (int i = 1; i < 5; i++)
            {
                Console.Write(string.Format("Enter element {0}: ", i));
                string x = Console.ReadLine();

                while (!Utilities.Validation(x, 0, 100))
                {
                    Console.WriteLine("Please enter a valid number");
                    x = Console.ReadLine();
                }
                int y = int.Parse(x);

                list.Add(y);
            }

            int[] array = list.ToArray();

            int sum = array.Sum();

            Console.WriteLine("Sum of all elements stored in the array is: {0}", sum);
        }
    }
}
