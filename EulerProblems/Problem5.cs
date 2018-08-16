using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem5
    {
        /*
         * SOLVED
         * Problem: What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
         */
        public static void ProblemAnswer()
        {
            /*Brute force method. It works*/
            int k = 20;
            int divisorCount = 0;
            for(int i = 1; ; i++)
            {
                divisorCount = 0;
                for(int j = 1; j<=k; j++)
                {
                    if(i%j == 0)
                    {
                        divisorCount++;
                    }
                    if(divisorCount==k)
                    {
                        Console.WriteLine("Euler Problem 5 Answer: " + i);
                        Console.Write("Press ENTER to continue.");
                        Console.ReadLine();
                    }
                }
                if (divisorCount == k)
                {
                    break;
                }
            }
           
        }
    }
}
