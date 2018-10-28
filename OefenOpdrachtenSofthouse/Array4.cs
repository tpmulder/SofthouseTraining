using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Array4
    {
        public static void Program15()
        {
            List<int> list = new List<int>();

            Console.WriteLine("How many elements do you want to add to your list? (max 10)");
            Console.Write("Amount of elements: ");
            string x = Console.ReadLine();

            while (!Utilities.Validation(x, 0, 10))
            {
                Console.WriteLine("Please enter a valid number");
                x = Console.ReadLine();
            }

            int y = int.Parse(x);

            for (int i = 1; i < y + 1; i++)
            {
                Console.Write("Enter element {0} (max 100): ", i);
                string z = Console.ReadLine();

                while (!Utilities.Validation(z, 0, 100))
                {
                    Console.WriteLine("Please enter a valid number");
                    z = Console.ReadLine();
                }

                int w = int.Parse(z);
                list.Add(w);
            }

            Console.WriteLine("Elements of list in ascending order");

            var result = from element in list
                         orderby element ascending
                         select element;

            foreach (var element in result)
            {
                Console.Write(element);
                Console.Write(" ");
            }
        }
    }
}
