using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public static class EulerHelper
    {
        

        /*Fibonnaci sequence finder for Problem 2*/
        public static int FibNthValue(int num)
        {
            if (num <= 0)
            {
                return 0;
            }
            else if (num == 1 || num == 2)
            {
                return 1;
            }
            else
            {
                return FibNthValue(num - 1) + FibNthValue(num - 2);
            }
        }
        
        /*Returns bool if int is divisible*/
        public static bool IsIntDivisible(int dividend, int divisor)
        {
            if (dividend % divisor == 0)
                return true;
            else
                return false;
        }

        public static bool IsPrime(int num)
        {
            if(num < 2)
            {
                return false;
            }
            if(num == 2)
            {
                return true;
            }
            if(num%2 == 0)
            {
                return false;
            }
            
            for(int i = 3; i*i < num; i += 2)
            {
                if(num%i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
