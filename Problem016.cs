/*Project Euler - Problem 16
 * 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
 * What is the sum of the digits of the number 2^1000?
 */

using System;
using System.Numerics;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BigInteger twoToThousandth = (BigInteger)Math.Pow(2, 1000);
            BigInteger sum = 0;

            for (int i = 1; i <= 1000; i++)
            {
                sum += twoToThousandth % 10;
                twoToThousandth /= 10;
            }
            
            Console.WriteLine(sum);
        }
    }
}
