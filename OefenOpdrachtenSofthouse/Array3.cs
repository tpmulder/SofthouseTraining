using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Array3
    {
        public static void Program14()
        {
            List<int> list = new List<int>();

            Console.WriteLine("How many elements do you want to add to your list? (5 - 20)");
            Console.Write("Amount of elements: ");
            string x = Console.ReadLine();

            while (!Utilities.Validation(x, 5, 20))
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
            var secondHighest = (from element in list
                         orderby element descending
                         select element).Skip(1).First();

            var secondLowest = (from element in list
                         orderby element ascending
                         select element).Skip(1).First();

            int maxValue = list.Max();
            int minValue = list.Min();

            Console.WriteLine("Highest number: {0}, second highest number: {3} lowest number: {1}, second lowest number: {4}", maxValue, minValue, secondHighest, secondLowest);
        }
    }
}
