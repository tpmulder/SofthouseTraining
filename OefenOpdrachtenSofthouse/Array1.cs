using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Array1
    {
        static void Main12(string[] args)
        /* 
        Haal het nummer achter "Main" weg en druk op start als je het programma wilt starten
        Maar zet deze wel weer terug als je het programma niet meer nodig hebt
        */
        {
            List<int> list = new List<int>();

            for (int i = 1; i < 5; i++)
            {
                Console.Write(string.Format("Enter element {0}: ", i));
                int x = Convert.ToInt32(Console.ReadLine());
                list.Add(x);
            }


            int[] array = list.ToArray();

            int sum = array.Sum();

            Console.WriteLine("Sum of all elements stored in the array is: {0}", sum);

            Console.ReadLine(); // Dit is zodat je in het programma blijft nadat je alles hebt ingevoerd
        }
    }
}
