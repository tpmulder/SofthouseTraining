using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class String4
    {
        public static void Program19()
        {
            Console.WriteLine("Input original string: ");
            string x = Console.ReadLine();

            Console.WriteLine("Input word to be searched for: ");

            string p = Console.ReadLine();
            string sub = p.Substring(0, p.Length);

            Console.WriteLine("Original string: {0}", x);
            Console.WriteLine("Search for in string: {0}", p);
            Console.WriteLine(TextTool.CountStringOccurrences(x, sub));
        }
    }

    public static class TextTool
    {
        public static int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;

            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
    }
}

