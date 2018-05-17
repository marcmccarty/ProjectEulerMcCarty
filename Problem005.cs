/*Project Euler - Problem 5
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */

using System;
using System.Collections;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // My idea here is that factorization will have certain numbers be included automatically
            // Like, if I add 1, 2, and 3 into the mix, then 6 is also present.
            // I'd need to add another 2 to handle 4, and then 5 to handle 5.
            // But now I've got 10 and 15 present as well, so they won't need to be multiplied in.

            // necessaryFactors will start with the primes and 1
            ArrayList necessaryFactors = new ArrayList();

            necessaryFactors.Add(1);
            necessaryFactors.Add(2);
            necessaryFactors.Add(3);
            necessaryFactors.Add(5);
            necessaryFactors.Add(7);
            necessaryFactors.Add(11);
            necessaryFactors.Add(13);
            necessaryFactors.Add(17);
            necessaryFactors.Add(19);

            long currentNecessaryMax = 1;

            foreach (int factor in necessaryFactors)
            {
                currentNecessaryMax *= factor;
            }

            for (int i = 1; i <= 20; i++)
            {
                // If our current number can't divide by, say, 4...
                if (currentNecessaryMax % i != 0)
                {
                    // We need to multiply by 2
                    currentNecessaryMax *= addNecessaryFactor(i, necessaryFactors);
                }
            }
            
            Console.WriteLine(currentNecessaryMax);
        }

        static int addNecessaryFactor(int necessaryFactor, ArrayList necessaryFactors)
        {
            foreach (int factor in necessaryFactors)
            {
                if (factor != 1)
                {
                    if (necessaryFactor % factor == 0)
                    {
                        necessaryFactors.Add(factor);
                        return factor;
                    }
                } 
            }
            return 1;
        }
    }
}
