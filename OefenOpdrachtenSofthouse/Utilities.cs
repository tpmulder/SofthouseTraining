using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdrachtenSofthouse
{
    public static class Utilities
    {
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
