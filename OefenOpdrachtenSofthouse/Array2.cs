using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Array2
    {
        public static void Program13()
        {
            bool detected = false;

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

            Console.WriteLine("Unique elements in list: \n");

            for (int i = 0; i < y; i++)
            {
                detected = false;

                for (int j = 0; j < y; j++)
                {
                    if (i!=j)
                    {
                        if (list[i] == list[j])
                        {
                            detected = true;

                            break;
                        }
                    }
                }

                if (detected == false)
                {
                    Console.Write("{0} ", list[i]);
                }
            }
        }
    }
}
