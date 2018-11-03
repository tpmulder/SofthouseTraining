using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class SecretHandshake
    {
        public static void Program26()
        {
            List<string> list = new List<string>();
            Console.WriteLine("Welcome to the secret handshake");
            Console.Write("Input a number (max 50): ");

            int wink = 1;
            int doubleWink = 10;
            int closeYourEyes = 100;
            int jump = 1000;
            int reverse = 10000;

            string Wink = "wink";
            string DoubleWink = "double blink";
            string CloseYourEyes = "close your eyes";
            string Jump = "jump";

            string input = Console.ReadLine();
            while (!Utilities.Validation(input, 1, 50))
            {
                Console.WriteLine("Please input a valid number");
                input = Console.ReadLine();
            }

            // lelijkste code ooit
            int x = int.Parse(input);
            string y = Convert.ToString(x, 2);
            int binary = int.Parse(y);

            int i = binary;

            for (; i >= reverse; i -= reverse)
            {
                
            }
            for (; i >= jump; i -= jump)
            {
                list.Add(Jump);
            }
            for (; i >= closeYourEyes; i -= closeYourEyes)
            {
                list.Add(CloseYourEyes);
            }
            for (; i >= doubleWink; i -= doubleWink)
            {
                list.Add(DoubleWink);
            }
            for (; i >= wink; i -= wink)
            {
                list.Add(Wink);
            }
            list.Reverse();
            for (int j = binary; j >= reverse; j -= reverse)
            {
                list.Reverse();
            }

            string[] array = list.ToArray();

            Console.WriteLine("{0} is {1} in binary code", x, binary);
            Console.WriteLine("the code created the following handshake\n");

            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[k]);
                Console.WriteLine(" ");
            }
        }
    }
}
