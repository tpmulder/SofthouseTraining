using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class String3
    {
        static void Main18(string[] args)
        /* 
        Haal het nummer achter "Main" weg en druk op start als je het programma wilt starten
        Maar zet deze wel weer terug als je het programma niet meer nodig hebt
        */
        {
            Console.WriteLine("Input string: ");
            string p = Console.ReadLine();

            char[] array = p.ToCharArray();

            Console.WriteLine("Elements of list in descending order");

            var result = from element in array
                         orderby element descending
                         select element;

            foreach (var element in result)
            {
                Console.Write(element);
                Console.Write(" ");
            }

            Console.ReadLine(); // Dit is zodat je in het programma blijft nadat je alles hebt ingevoerd
        }
    }
}
