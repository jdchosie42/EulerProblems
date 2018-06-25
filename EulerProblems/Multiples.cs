using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public static class Multiples
    {
        /* 
         * If division doesn't return a remainder, return true
         */
        public static bool IsIntDivisible(int dividend, int divisor)
        {
            if (dividend % divisor == 0)
                return true;
            else
                return false;
        }
    }
}
