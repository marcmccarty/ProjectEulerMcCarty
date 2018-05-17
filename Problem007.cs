/*Project Euler - Problem 7
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 * 
 * What is the 10001st prime number?
 */

using System;
using System.Collections.Generic;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int N = 1000000; //Setting to 1m because it's unlikely the 10001st prime would be as rare as 1/100 yet
            int count = 1;
            List<bool> primes = new List<bool>(N);
            
            // Fill list with true values by default
            // Otherwise, when trying to set them via "= sign" later, you'll get Index Out of Bounds types of errors
            for (int k = 0; k < primes.Capacity; k++)
            {
                primes.Add(true);
            }
            
            // Jump 2 to skip even numbers
            // No primes are even
            // I learned a better algorithm that I used in Problem 10
            for (int i = 3; i*i < N; i += 2)
            {
                for (int j = 3; j*i < N; j+=2)
                {
                    primes[j*i] = false;
                }
            }
            
            for (int i = 3; i < N; i+=2)
            {
                if (primes[i])
                {
                    count++;
                    if (count == 10001)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
