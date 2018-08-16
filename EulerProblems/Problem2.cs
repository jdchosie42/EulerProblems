using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public static class Problem2
    {
        /* SOLVED
         * 
         * Problem: By considering the terms in
         * the Fibonacci sequence whose values do not exceed 
         * four million, find the sum of the even-valued terms.
         */

        public static int Fib(int n)
        {
            return EulerHelper.FibNthValue(n);
        }

        public static void ProblemAnswer()
        {
            /* 
             * Different method. Helps to eliminate repeat calculations by only
             * finding every 3rd value of fib series.
             */

            int limit = 4000000;
            int answer = 0;
            int a = 1;
            int b = 1;
            int c = a + b;

            while (c < limit)
            {
                answer += c;
                a = b + c;
                b = c + a;
                c = a + b;
            }
           /* int answer = 0;
            for(int i = 0;; i++)
            {
                int val = Fib(i);
                if(val < 4000000)
                {
                    if(val % 2 == 0)
                    {
                        answer += val;
                    }
                }
                else
                {
                    break;
                }
            }*/
            Console.WriteLine("Euler Problem 2 Answer: " + answer);
            Console.Write("Press ENTER to continue.");
            Console.ReadLine();
        }
    }
}
