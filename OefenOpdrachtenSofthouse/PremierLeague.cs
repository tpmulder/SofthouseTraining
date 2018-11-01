using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    class PremierLeague
    {
        public static void Program27()
        {

            string results = "Manchester United 1 Chelsea 0, Arsenal 1 Manchester United 1, Manchester United 3 Fulham 1, Liverpool 2 Manchester United 1, Swansea 2 Manchester United 4";

            string[] array = results.Split(',');
            string invalid = "Invalid score\nplease check your string";

            string[] teams = new string[5] { "Chelsea", "Arsenal", "Fulham", "Liverpool", "Swansea" };
            int[] wins = new int[5] { 0, 0, 0, 0, 0 };
            int[] draws = new int[5] { 0, 0, 0, 0, 0 };
            int[] defeats = new int[5] { 0, 0, 0, 0, 0 };
            int[] points = new int[5] { 0, 0, 0, 0, 0 };
            int[] scored = new int[5] { 0, 0, 0, 0, 0 };
            int[] conceided = new int[5] { 0, 0, 0, 0, 0 };

            int winsMan = 0;
            int drawsMan = 0;
            int defeatsMan = 0;
            int pointsMan = 0;

            int scoredMan = 0;
            int conceidedMan = 0;

            for (int i = 0; i < array.Length; i++)
            {
                while (Utilities.getResults(array[i], "Manchester United") == invalid)
                {
                    Console.WriteLine(invalid);
                    Console.WriteLine("Please exit to the main menu (press ESC)");

                    ConsoleKeyInfo keyPressed = Console.ReadKey();

                    if (keyPressed.Key == ConsoleKey.Escape)
                    {
                        MainProgram.Main(null);
                    }
                }

                string resultMan = Utilities.getResults(array[i].Trim(), "Manchester United");
                string[] matchFactsMan = resultMan.Split('.');

                if (matchFactsMan[0] == "0")
                {
                    defeatsMan++;
                }
                if (matchFactsMan[0] == "1")
                {
                    drawsMan++;
                    pointsMan = pointsMan + 1;
                }
                if (matchFactsMan[0] == "3")
                {
                    winsMan++;
                    pointsMan = pointsMan + 3;
                }

                scoredMan = scoredMan + int.Parse(matchFactsMan[1]);
                conceidedMan = conceidedMan + int.Parse(matchFactsMan[2]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                string result = Utilities.getResults(array[i].Trim(), teams[i]);
                string[] matchFacts = result.Split('.');

                if (matchFacts[0] == "0")
                {
                    defeats[i]++;
                }
                if (matchFacts[0] == "1")
                {
                    draws[i]++;
                    points[i] = points[i] + 1;
                }
                if (matchFacts[0] == "3")
                {
                    wins[i]++;
                    points[i] = points[i] + 3;
                }

                scored[i] = scored[i] + int.Parse(matchFacts[1]);
                conceided[i] = conceided[i] + int.Parse(matchFacts[2]);
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("{0, 10} | {1, 8} | {2, 8} | {3, 8} | {4, 8} | {5, 8} | {6, 8} |",
                                            "Team", "wins", "draws", "defeats", "scored", "conceded", "points"));
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("{0, 10} | {1, 8} | {2, 8} | {3, 8} | {4, 8} | {5, 8} | {6, 8} |",
                                            "Manchester",winsMan.ToString(), drawsMan.ToString(), defeatsMan.ToString(), scoredMan.ToString(), conceidedMan.ToString(), pointsMan.ToString()));
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < teams.Length; i++)
            {
                Console.WriteLine(String.Format("{0, 10} | {1, 8} | {2, 8} | {3, 8} | {4, 8} | {5, 8} | {6, 8} |",
                                teams[i], wins[i].ToString(), draws[i].ToString(), defeats[i].ToString(), scored[i].ToString(), conceided[i].ToString(), points[i].ToString()));
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
        }
    }
}
