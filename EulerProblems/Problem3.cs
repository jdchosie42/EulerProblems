using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public static class Problem3
    {
        /*
         * SOLVED
         * Problem: What is the largest prime factor of the number 600851475143?
         */
        public static void Problem3Answer()
        {
            var bigNum = 600851475143;
            var primeFactor = 0;
            for (var i = 2; i * i < bigNum; i++)
            {
                if (bigNum % i == 0 && EulerHelper.IsPrime(i))
                {
                    bigNum /= i;
                    primeFactor = i;
                }
            }

            Console.WriteLine("Euler Problem 3 Answer: " + bigNum);
            Console.Write("Press ENTER to continue.");
            Console.ReadLine();
        }
    }
}
