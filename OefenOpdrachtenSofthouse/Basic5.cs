using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Basic5
    {
        public static void Program5()
        /* 
        Haal het nummer achter "Main" weg en druk op start als je het programma wilt starten
        Maar zet deze wel terug als je het programma niet meer nodig hebt
        */
        {
            int n, x, y;
            List<int> list = new List<int>();

            Console.WriteLine("Basic5 - ");

            for (int i = 0; i < 1; i++)
            {
                Console.Write("Enter x and y: ");

                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Please Enter an int: ");
                }
                list.Add(n);
            }
            x = list[1];
            y = list[2];

            Console.WriteLine("equasion to solve: x = y² - 2y +1");

            for (y = -5; y <= 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine(
                    "y = {0} ; x=({0})² - 2*({0}) +1 = {1}",
                    y, x);
            }
        }
    }
}
