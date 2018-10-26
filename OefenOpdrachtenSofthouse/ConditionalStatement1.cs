using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class ConditionalStatement1
    {
        public static void Program8()
        {
            char x;
            bool validation = false;

            Console.WriteLine("ConditionalStatement1 - A program that checks if the given letter is a vowel or a consonant\n");
            Console.Write("Input a letter: ");

            while (validation == false)
            {
                while (!char.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Please Enter a single letter: ");
                }
                if (char.IsLetter(x) == true)
                {
                    validation = true;
                    if ((x == 'a') || (x == 'e') || (x == 'i') ||
                        (x == 'o') || (x == 'u'))
                        Console.WriteLine("The letter is a vowel");
                    else
                        Console.WriteLine("The letter is a consonant");
                }
                else
                {
                    Console.WriteLine("Letters only please");
                }
            }
        }
    }
}
