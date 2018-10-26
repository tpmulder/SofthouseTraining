using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Basic3
    {
        public static void Program3()
        {
            bool retry = true;

            Console.WriteLine("Basic3 - A program that creates a new string from a given string.\n");

            while (retry == true)
            {
                Console.WriteLine("Input string:");
                string x = Console.ReadLine();

                if (x.Length >= 3)
                {
                    string firstLetter = x.Substring(0, 1);
                    string lastLetter = x.Substring(x.Length - 1);
                    string restLetter = x.Substring(1, x.Length - 2);

                    string newString = lastLetter + restLetter + firstLetter;

                    Console.WriteLine("\nOld string: {0}", x);
                    Console.WriteLine("New string: {0}\n", newString);
                }
                else
                {
                    Console.WriteLine("\nString has to be atleast 3 characters long.\n");
                }
            }
        }
    }
}
