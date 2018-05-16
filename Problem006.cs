/*Project Euler - Problem 6
 * The sum of the squares of the first ten natural numbers is,
 * 1sq + 2sq + ... + 10sq = 385 
 *  
 * The square of the sum of the first ten natural numbers is,
 * (1 + 2 + ... + 10)2 = 552 = 3025
 *
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
 *
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */

using System;
using System.Collections;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Sum of Squares
            double sumOfSquares = 0;
            for (double i = 1; i < 101; i++)
            {
                sumOfSquares += Math.Pow(i, 2);
            }
            
            
            //Square of Sums
            double sumsToSquare = 0;
            for (double j = 1; j < 101; j++)
            {
                sumsToSquare += j;
            }

            double squaredSums = Math.Pow(sumsToSquare, 2);


            //Difference
            Console.WriteLine(squaredSums - sumOfSquares);
        }
    }
}
