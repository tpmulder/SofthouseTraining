using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Array3
    {
        static void Main14(string[] args)
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

            int maxValue = list.Max();
            int minValue = list.Min();

            Console.WriteLine("Highest number {0}, Lowest number {1}", maxValue, minValue);
            
            

            Console.ReadLine(); // Dit is zodat je in het programma blijft nadat je alles hebt ingevoerd
        }
    }
}
