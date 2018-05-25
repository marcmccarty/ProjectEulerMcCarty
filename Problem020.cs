/*Project Euler - Problem 20
 * n! means n × (n − 1) × ... × 3 × 2 × 1
 * 
 * For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800
 * and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
 *
 * Find the sum of the digits in the number 100!
 */
 
 using System;
 using System.Numerics;

namespace ProjectEulerWorkspace
 {
     internal class Program
     {
         public static void Main(string[] args)
         {
             BigInteger hundredFact;

             hundredFact = factorial(100);
             
             Console.WriteLine(sumOfDigits(hundredFact));
         }

         private static BigInteger factorial(BigInteger toFact)
         {
             if (toFact == 1)
             {
                 return 1;
             }

             return toFact * factorial(toFact - 1);
         }

         private static BigInteger sumOfDigits(BigInteger bigFact)
         {
             BigInteger sum = 0;
             
             while (bigFact >= 10)
             {
                 sum += bigFact % 10;
                 bigFact /= 10;
             }

             sum += bigFact;
             
             return sum;
         }
     }
 }
