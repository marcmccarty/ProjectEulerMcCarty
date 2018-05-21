/*Project Euler - Problem 15
 * Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
 * How many such routes are there through a 20×20 grid?
 */

using System;
using System.Numerics;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            long gridLength = 20;
            long gridHeight = 20;
            BigInteger possiblePaths;
            
            // Variables for the combination equation of (C1!/C2!)/C3!
            BigInteger C1 = factorial(gridHeight + gridLength);
            BigInteger C2 = factorial(gridHeight);
            BigInteger C3 = factorial(gridLength);
            
            // This is a combination problem
            possiblePaths = (C1 / C2) / C3;
            
            Console.WriteLine(possiblePaths);
        }

        static BigInteger factorial(BigInteger n)
        {
            if (n == 0)
            {
                return 1;
            }
            
            return n * factorial(n - 1);
        }
    }
}
