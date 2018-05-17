/*Project Euler - Problem 9
 * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
 *
 * a^2 + b^2 = c^2
 * For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
 *
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
 * Find the product abc.
 */

using System;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool productFound = false;
            int c = 3;
            
            // Essentially n^3 runtime. Seems like it could be improved.
            while (!productFound && c < 997)
            {
                for (int b = 2; b < c; b++)
                {
                    for (int a = 1; a < b; a++)
                    {
                        if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) && (a + b + c == 1000))
                        {
                            Console.WriteLine(a * b * c);
                            productFound = true;
                        }
                    }
                }
                c++;
            }
        }
    }
}
