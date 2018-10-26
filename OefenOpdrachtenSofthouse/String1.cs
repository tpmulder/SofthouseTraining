using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class String1
    {
        static void Main16(string[] args)
        /* 
        Haal het nummer achter "Main" weg en druk op start als je het programma wilt starten
        Maar zet deze wel terug als je het programma niet meer nodig hebt
        */
        {
            int i = 0;
            int wordCount = 1;

            Console.Write("String: ");
            string str = Console.ReadLine();

            while (i <= str.Length -1)
            {
                if(str[i]== ' ')
                {
                    wordCount++;
                }
            i++;
            }

            Console.Write("Total number of words in string: {0}", wordCount);

            Console.ReadLine(); // Dit is zodat je in het programma blijft nadat je alles hebt ingevoerd
        }
    }
}
