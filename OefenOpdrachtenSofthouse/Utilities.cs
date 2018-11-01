using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    public static class Utilities
    {
        public static string getResults(string result, string team)
        {

            string[] results = result.Split(' ');
            int homeScore = 0;
            int awayScore = 0;
            int count = 0;

            for (int i = 0; i < results.Length; i++)
            {
                int x;
                string invalid = "Invalid score\nplease check your string";
                bool validation = false;
                validation = int.TryParse(results[i], out x);
                if (validation && x >= 0 )
                {
                    if (count == 0)
                    {
                        homeScore = x;
                        count++;
                    }
                    else
                    {
                        awayScore = x;
                    }
                }
                else if (validation)
                {
                    return invalid;
                }
            }

            string homeWin = "3";
            string awayWin = "3";
            string draw = "1";
            string loss = "0";

            string pointsGoals = "";

            int Team = result.IndexOf(team);

            if (Team == 0)
            {
                if (homeScore > awayScore)
                {
                    pointsGoals = homeWin + "." + homeScore.ToString() + "." + awayScore.ToString();
                }
                else if (awayScore > homeScore)
                {
                    pointsGoals = loss + "." + homeScore.ToString() + "." + awayScore.ToString();
                }
                else if (homeScore == awayScore)
                {
                    pointsGoals = draw + "." + homeScore.ToString() + "." + awayScore.ToString();
                }
            }
            else
            {
                if (awayScore > homeScore)
                {
                    pointsGoals = awayWin + "." + awayScore.ToString() + "." + homeScore.ToString();
                }
                else if (homeScore > awayScore)
                {
                    pointsGoals = loss + "." + awayScore.ToString() + "." + homeScore.ToString();
                }
                else if (homeScore == awayScore)
                {
                    pointsGoals = draw + "." + awayScore.ToString() + "." + homeScore.ToString();
                }
            }

            return pointsGoals;
        }

        public static bool Validation(string input, int minValue, int maxValue)
        {
            int n;

            if (int.TryParse(input, out n))
            {
                if (n >= minValue && n <= maxValue)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
