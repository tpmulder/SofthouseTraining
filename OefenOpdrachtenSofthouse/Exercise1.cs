using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Exercise1
    {
        public static void Program20()
        {
            Console.WriteLine("Input a string:");
            string x = Console.ReadLine();

            char[] charArray = x.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine("The reversed string is:");
            Console.Write(charArray);
        }
    }
}
