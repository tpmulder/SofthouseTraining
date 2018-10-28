using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            int x = 0;
            int programCount = 19;
            bool validation = false;
            bool stayInProgram = true;

            Console.WriteLine("Wich program do you want to run?\n");
            Console.WriteLine("\t1 - Basic1");
            Console.WriteLine("\t2 - Basic2");
            Console.WriteLine("\t3 - Basic3");
            Console.WriteLine("\t4 - Basic4");
            Console.WriteLine("\t5 - Basic5");
            Console.WriteLine("\t6 - Basic6");
            Console.WriteLine("\t7 - Basic7");
            Console.WriteLine("\t8 - ConditionalStatement1");
            Console.WriteLine("\t9 - ForLoop1");
            Console.WriteLine("\t10 - ForLoop2");
            Console.WriteLine("\t11- ForLoop3");
            Console.WriteLine("\t12 - Array1");
            Console.WriteLine("\t13 - Array2");
            Console.WriteLine("\t14 - Array3");
            Console.WriteLine("\t15 - Array4");
            Console.WriteLine("\t16 - String1");
            Console.WriteLine("\t17 - String2");
            Console.WriteLine("\t18 - String3");
            Console.WriteLine("\t19 - String4");

            Console.Write("Program: ");
            while (validation == false)
            {
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("\nPlease enter an int");
                }

                if (x <= 19)
                {
                    Console.WriteLine("Executing program {0}...", x);
                    validation = true;

                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid program number ( 1 - {0}", programCount);
                }
            }
            
            while (stayInProgram == true)
            {
                if (x == 1)
                {
                    Basic1.Program1();
                }
                else if (x == 2)
                {
                    Basic2.Program2();
                }
                else if (x == 3)
                {
                    Basic3.Program3();
                }
                else if(x == 4)
                {
                    Basic4.Program4();
                }
                else if(x == 5)
                {
                    Basic5.Program5();
                }
                else if(x == 6)
                {
                    Basic6.Program6();
                }
                else if(x == 7)
                {
                    Basic7.Program7();
                }
                else if(x == 8)
                {
                    ConditionalStatement1.Program8();
                }
                else if (x == 9)
                {
                    ForLoop1.Program9();
                }
                else if (x == 9)
                {
                    ForLoop1.Program9();
                }
                else if (x == 10)
                {
                    ForLoop2.Program10();
                }
                else if (x == 11)
                {
                    ForLoop3.Program11();
                }
                else if (x == 12)
                {
                    Array1.Program12();
                }
                else if (x == 13)
                {
                    Array2.Program13();
                }
                else if (x == 14)
                {
                    Array3.Program14();
                }
                else if (x == 15)
                {
                    Array4.Program15();
                }
                else if (x == 16)
                {
                    String1.Program16();
                }
                else if (x == 17)
                {
                    String2.Program17();
                }
                else if (x == 18)
                {
                    String3.Program18();
                }
                else if (x == 19)
                {
                    String4.Program19();
                }

                bool stillGoing = true;

                Console.WriteLine("\nThe program is done now");

                while (stillGoing == true)
                {
                    bool wrongKey = true;
                    Console.WriteLine("\nDo you want to rerun (R) or exit (E) the program?");

                    ConsoleKeyInfo keyPressed = Console.ReadKey();
                    if (keyPressed.Key == ConsoleKey.E)
                    {
                        while (wrongKey == true)
                        {
                            Console.WriteLine("\nDo you really want to exit? (Y / N)");
                            ConsoleKeyInfo exitKeyPressed = Console.ReadKey();

                            if (exitKeyPressed.Key == ConsoleKey.Y)
                            {
                                Console.WriteLine("\nReturning to main menu...");
                                Main(null);
                                wrongKey = false;
                                stillGoing = false;
                                stayInProgram = false;
                            }
                            else if (exitKeyPressed.Key == ConsoleKey.N)
                            {
                                wrongKey = false;
                            }
                            else
                            {
                                Console.WriteLine("\nPlease Enter \"Y\" or \"N\"");
                            }
                        }
                    }
                    else if (keyPressed.Key == ConsoleKey.R)
                    {
                        Console.WriteLine("\nRerunning app...");
                        stillGoing = false;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease Enter \"R\" or \"E\"");
                    }
                }
            }
        }
    }
}
