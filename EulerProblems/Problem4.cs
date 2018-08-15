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
         * SOLVED
         * Problem: Find the largest palindrome made from the product of two 3-digit numbers.
         */
        public static void ProblemAnswer()
        {
            /*Better than a brute force method*/
            int largestPalindrome = 0;

            for (int x = 999; x >= 100; x--)
            {
                for (int y = 999; y >= x; y--)
                {
                    int product = x * y;

                    if (product <= largestPalindrome)
                        break;

                    if (EulerHelper.IsPalindrome(product))
                        largestPalindrome = product;
                }
            }

            Console.WriteLine("Euler Problem 4 Answer: " + largestPalindrome);
            Console.Write("Press ENTER to continue.");
            Console.ReadLine();
        }
    }
}
