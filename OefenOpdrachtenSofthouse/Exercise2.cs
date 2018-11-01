using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Exercise2
    {
        public static void Program21()
        {
            List<char> list = new List<char>();

            Console.WriteLine("Input a sentence:");
            string x = Console.ReadLine();
            string y = "abcdefghijklmnopqrstuvwxyz";

            x.ToLower();

            char[] charArray = x.ToCharArray();
            char[] alphabet = y.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i]))
                {
                    list.Add(charArray[i]);
                }
            }

            List<char> filteredList = list.Distinct().ToList();

            if (filteredList.LongCount() == 26)
            {
                Console.WriteLine("The sentence is a pangram");
            }
            else
            {
                Console.WriteLine("The sentence is not a pangram");
            }

            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    for (int j = 0; j < alphabet.Length; j++)
            //    {
            //        if (alphabet[j] == charArray[i])
            //        {
            //            list.Add(alphabet[j]);
            //            Console.WriteLine("{0} - Detected", alphabet[j]);
            //            break;
            //        }
            //    }
            //}
            //List<char> filteredList = list.Distinct().ToList();

            //char[] checkedAlphabets = filteredList.ToArray();

            //Array.Sort(checkedAlphabets);
            //Array.Sort(alphabet);

            //Console.WriteLine("\nChecking strings...\n");
            //Console.Write(checkedAlphabets);
            //Console.WriteLine(" (" + checkedAlphabets.Length + ")");
            //Console.Write(alphabet);
            //Console.WriteLine(" (" + alphabet.Length + ")");
            //Console.WriteLine("\n\n");

            //string z = new string(checkedAlphabets);
            //string w = new string(alphabet);

            //if (z == w)
            //{
            //    Console.WriteLine("This sentence is a pangram");
            //}
            //else
            //{
            //    Console.WriteLine("This sentence is not a pangram");
            //}
        }
    }
}
