using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class String2
    {
        static void Main17(string[] args)
        /* 
        Haal het nummer achter "Main" weg en druk op start als je het programma wilt starten
        Maar zet deze wel terug als je het programma niet meer nodig hebt
        */
        {
            Console.Write("Input something: ");
            string x = Console.ReadLine();

            int l = x.Count(char.IsLetter);
            int d = x.Count(char.IsDigit);
            int s = x.Count(char.IsSymbol);

            Console.WriteLine("Alphabets: {0},\nDigits: {1},\nSpecial characters: {2}", l, d, s);
            Console.Read();
        }
    }
}
