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
            string results = "Manchester United 1 Chelsea 0, Arsenal 1 Manchester United 1, Manchester United 3 Fullham 1, Liverpool 2 Manchester United 1, Swansea 2 Manchester United 4";
            string[] x = results.Split(',');

            for (int i = 0; i < x.Length; i++)
            {
                string y = String.Format("{0, 34}", x[i]);

                Console.WriteLine(y);
            }

        }
    }
}
