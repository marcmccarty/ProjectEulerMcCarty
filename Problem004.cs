/* Project Euler - Problem 4
 * A palindromic number reads the same both ways.
 * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */

using System;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int testNum = 999 * 999;
            int originalNum = 0;

            int highestPalindrome = 0;
            
            int sixthDigit = 0;
            int fifthDigit = 0;
            int fourthDigit = 0;
            int thirdDigit = 0;
            int secondDigit = 0;
            int firstDigit = 0;

            int countdown1 = 999;
            int countdown2 = 999;
            
            int countdown = countdown1 * countdown2;
            bool oddRun = true;

            while (highestPalindrome == 0 && countdown > 100000)
            {
                testNum = countdown;
                originalNum = countdown;

                // Stripping digits from testNum while retaining originalNum
                sixthDigit = testNum % 10;
                testNum /= 10;
                
                fifthDigit = testNum % 10;
                testNum /= 10;
                
                fourthDigit = testNum % 10;
                testNum /= 10;
                
                thirdDigit = testNum % 10;
                testNum /= 10;
                
                secondDigit = testNum % 10;
                testNum /= 10;
                
                firstDigit = testNum % 10;

                if (sixthDigit == firstDigit && fifthDigit == secondDigit && fourthDigit == thirdDigit)
                {
                    highestPalindrome = originalNum;
                }

                countdown1 -= 1;
                
                // The highest palindrome for two 3-digit numbers is likely from ones that are 900+
                // i.e. 999*5## that may make a palindrome isn't as big as say 993*913 (the answer in this case)
                if (countdown1 == 900)
                {
                    countdown2 -= 1;
                    countdown1 = 999;
                }
                Console.WriteLine(countdown1);
                countdown = countdown1 * countdown2;
            }
            
            Console.WriteLine(highestPalindrome);
        }
    }
}
