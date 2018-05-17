/*Project Euler - Problem 10
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 * Find the sum of all the primes below two million.
 */

using System;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double limit = 2000000;
            double sumOfPrimes = 2;

            for (double i = 1; i < limit; i += 2)
            {
                if (isPrime(i))
                {
                    sumOfPrimes += i;
                }
            }
            
            Console.WriteLine(sumOfPrimes);
        }

        public static bool isPrime(double num)
        {
            double r = 0;
            double f = 5;
            if (num == 1)
            {
                return false;
            }
            else if (num < 4)
            {
                return true;
            }
            else if (num % 2 == 0)
            {
                return false;
            }
            else if (num < 9)
            {
                return true;
            }
            else if (num % 3 == 0)
            {
                return false;
            }
            else
            {
                r = Math.Floor(Math.Sqrt(num));
                while (f <= r)
                {
                    if (num % f == 0)
                    {
                        return false;
                    }

                    if (num % (f + 2) == 0)
                    {
                        return false;
                    }

                    f = f + 6;
                }
            }

            return true;
        }
    }
}
