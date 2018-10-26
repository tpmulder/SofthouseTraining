using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Basic6
    {
        public static void Program6()
        {
            char x;

            Console.Write("Input a character: ");
            while (!char.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Please Enter a single character: ");
            }
            if ((x == 'a') || (x == 'e') || (x == 'i') ||
                    (x == 'o') || (x == 'u'))
                Console.Write("It's a vowel ");
            else if (char.IsDigit(x))
                Console.WriteLine("It's a digit ");
            else if (char.IsLetter (x))
                Console.Write("It's a consonant");
            else
                Console.WriteLine("It's another symbol");

            if (char.IsLetter(x) == true)
            {
                if (char.IsUpper(x))
                    Console.WriteLine("and it's uppercase");
                else
                    Console.WriteLine("and it's lowercase");
            }
        }
    }
}
