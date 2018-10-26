using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Array4
    {
        static void Main15(string[] args)
        /* 
        Haal het nummer achter "Main" weg en druk op start als je het programma wilt starten
        Maar zet deze wel weer terug als je het programma niet meer nodig hebt
        */
        {
            List<int> list = new List<int>();

            Console.WriteLine("How many elements do you want to add to your list? ");
            Console.Write("Amount of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                Console.Write("Enter element {0}: ", i);
                int x = Convert.ToInt32(Console.ReadLine());
                list.Add(x);
            }

            Console.WriteLine("Elements of list in ascending order");

            int[] array = list.ToArray();

            var result = from element in list
                         orderby element ascending
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
