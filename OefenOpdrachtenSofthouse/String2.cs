using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class String2
    {
        public static void Program17()
        {
            Console.Write("Input something: ");
            string x = Console.ReadLine();

            int l = x.Count(char.IsLetter);
            int d = x.Count(char.IsDigit);
            int s = x.Count(char.IsSymbol);

            Console.WriteLine("Alphabets: {0},\nDigits: {1},\nSpecial characters: {2}", l, d, s);
        }
    }
}
