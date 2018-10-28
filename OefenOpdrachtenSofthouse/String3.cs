using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class String3
    {
        public static void Program18()
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
        }
    }
}
