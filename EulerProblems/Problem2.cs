using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public static class Problem2
    {
        /* NOT SOLVED
         * 
         * Problem: By considering the terms in
         * the Fibonacci sequence whose values do not exceed 
         * four million, find the sum of the even-valued terms.
         */

        public static int Fib(int n)
        {
            return Fibonacci.nthValue(n);
        }

        public static void Problem2Answer()
        {
            /* Testing to make sure fibonacci sequence works
            Console.Write("Enter nth value of Fibonacci sequence: ");
            if(int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("Euler Problem 2 Answer: " + Fib(input));
                Console.WriteLine("Press any key to exit.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Input is not a number. Please Enter a number.");
            }*/
        }
    }
}
