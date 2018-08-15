using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public static class Problem4
    {
        /*
         * NOT SOLVED
         * Problem: Find the largest palindrome made from the product of two 3-digit numbers.
         */
        public static void ProblemAnswer()
        {
            /*Brute force method*/
            int largestPalindrome = 0;

            for (int x = 100; x <= 999; x++)
            {
                for (int y = 100; y <= 999; y++)
                {
                    if (EulerHelper.IsPalindrome(x * y) && x * y > largestPalindrome)
                    {
                        largestPalindrome = x * y;
                    }
                }
            }

            Console.WriteLine("Euler Problem 4 Answer: " + largestPalindrome);
            Console.Write("Press ENTER to continue.");
            Console.ReadLine();
        }
    }
}
