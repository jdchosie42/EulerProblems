using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public static class Problem1
    {
        /*
         * Brute force method that goes through each number individually and adds up all numbers divisible by 3 or 5.
         * Not very efficient, espiecally when going through a larger sample size.
         * 
        public static int SumDivisible()
        {
            int answer = 0;
            for (int i = 0; i < 1000; i++)
            {
                if( i%3 == 0 || i%5 == 0)
                    answer += i;
            }
            return answer;
        }
        */

        /*
         * A more elegant solution.
         */
        public static int SumDivisible(int n)
        {
            int counter = 999; //999 since we are looking for sum of eerything less than 1000
            int p = counter / n;
            return n * (p * (p + 1)) / 2;
        }

        public static void ProblemAnswer()
        {
            Console.WriteLine("Euler Problem 1 Answer: " + (SumDivisible(3) + SumDivisible(5) - SumDivisible(15)));
            Console.Write("Press ENTER to continue.");
            Console.ReadLine();
        }
    }
}
