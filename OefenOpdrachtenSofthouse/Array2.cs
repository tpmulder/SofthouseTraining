using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Array2
    {
        public void Main13(string[] args)
        /* 
        Haal het nummer achter "Main" weg en druk op start als je het programma wilt starten
        Maar zet deze wel weer terug als je het programma niet meer nodig hebt
        */
        {
            bool detected = false;

            List<int> list = new List<int>();

            Console.WriteLine("How many elements do you want to add to your list? ");
            Console.Write("Amount of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n+1; i++)
            {
                Console.Write("Enter element {0}: ", i);
                int x = Convert.ToInt32(Console.ReadLine());
                list.Add(x);
            }

            Console.WriteLine("Unique elements in list: \n");

            for (int i = 0; i < n; i++)
            {
                detected = false;

                for (int j = 0; j < n; j++)
                {
                    if (i!=j)
                    {
                        if (list[i] == list[j])
                        {
                            detected = true;

                            break;
                        }
                    }
                }

                if (detected == false)
                {
                    Console.Write("{0}", list[i]);
                }
            }

            Console.ReadLine(); // Dit is zodat je in het programma blijft nadat je alles hebt ingevoerd
        }
    }
}
