using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Exercise3
    {
        public static void Program22()
        {
            int sum = 0;
            Console.WriteLine("Enter a magic number (10 - 50): ");
            string inputX = Console.ReadLine();

            while (!Utilities.Validation(inputX, 10, 50))
            {
                Console.WriteLine("Please enter a valid number");
                inputX = Console.ReadLine();
            }
            int x = int.Parse(inputX);
            x -= 1;

            Console.Write("Enter a multiple (cant be 0, cant be larger than magic number): ");
            string inputY = Console.ReadLine();

            while (!Utilities.Validation(inputY, 1, x))
            {
                Console.WriteLine("Please enter a valid number ");
                inputY = Console.ReadLine();
            }
            int y = int.Parse(inputY);

            Console.Write("Enter a multiple (cant be 0, cant be larger than magic number, cant be the same as multiple 1): ");
            string inputZ = Console.ReadLine();

            while (!Utilities.Validation(inputZ, 1, x))
            {
                if (inputZ == inputY)
                {
                    Console.WriteLine("You can't enter the same value twice\nPlease enter a different value");
                    inputZ = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                    inputZ = Console.ReadLine();
                }
            }
            int z = int.Parse(inputZ);

            for (int i = x; i > 0; i--)
                if ((i % y == 0) || (i % z == 0))
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            Console.WriteLine("\nTotal value of all numbers: {0}", sum);
        }
    }
}
