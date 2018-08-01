using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public static class Fibonacci
    {
        /*A basic recursive method for finding the nth value of the Fibonacci sequence*/
        public static int nthValue(int num)
        {
            if(num <= 0)
            {
                return 0;
            }
            else if(num == 1 || num == 2)
            {
                return 1;
            }
            else
            {
                return nthValue(num - 1) + nthValue(num - 2);
            }
        }
    }
}
