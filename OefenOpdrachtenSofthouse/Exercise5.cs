using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class Exercise5
    {
        public static void Program24()
        {
            bool validation = false;
            bool allCapital = false;
            bool allCapitalAndQuestion = false;

            Console.WriteLine("Say something to bob!");
            string inputX = "";

            char[] charArray = inputX.ToCharArray();
            List<char> list = charArray.ToList();

            while (validation == false)
            {
                inputX = Console.ReadLine();

                charArray = inputX.ToCharArray();
                list = charArray.ToList();

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (!char.IsDigit(charArray[i]) && !char.IsSymbol(charArray[i]))
                    {
                        validation = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid sentence");
                        break;
                    }
                }
            }
            list.Remove(' ');

            char[] filteredList = list.ToArray();
            string noResponse = new string(filteredList);

            for (int j = 0; j < charArray.Length; j++)
            {
                if (char.IsUpper(charArray[j]) && charArray[charArray.Length - 1] != '?')
                {
                    allCapital = true;
                }
                else if (char.IsUpper(charArray[j]) && charArray[charArray.Length - 1] == '?')
                {
                    allCapitalAndQuestion = true;
                }
            }

            if (charArray[charArray.Length - 1] == '?' && !allCapitalAndQuestion)
            {
                Console.WriteLine("Bob's response:\nSure.");
            }
            else if (allCapital)
            {
                Console.WriteLine("Bob's response:\nWhoa, chill out!");
            }
            else if (allCapitalAndQuestion)
            {
                Console.WriteLine("Bob's response:\nCalm down, I know what I'm doing!");
            }
            else if (noResponse == "")
            {
                Console.WriteLine("Bob's response:\nFine. Be that way!");
            }
            else
            {
                Console.WriteLine("Whatever.");
            }
        }
    }
}
