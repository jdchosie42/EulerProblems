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

        /*Returns true if the number is a palindrome*/
        public static bool IsPalindrome(int num)
        {
            return num == Reverse(num);
        }

        /*Checks to see if a number is prime.*/
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

        /*Reverses the order of values in an int*/
        public static int Reverse(int num)
        {
            int reversed = 0;
            while(num > 0)
            {
                reversed = 10 * reversed + (num % 10);
                num /= 10;
            }
            return reversed;
        }
    }
}
