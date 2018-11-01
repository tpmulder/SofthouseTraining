using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class String1
    {
        public static void Program16()
        {
            string n = Console.ReadLine().Trim();
            int wordCount = 0, index = 0;
            while (index < n.Length)
            {
                // check if current char is part of a word
                while (index < n.Length && !char.IsWhiteSpace(n[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < n.Length && char.IsWhiteSpace(n[index]))
                    index++;

                while (index < n.Length && !char.IsSymbol(n[index]))
                    index++;
            }

            Console.Write("Total number of words in string: {0}", wordCount);
        }
    }
}
