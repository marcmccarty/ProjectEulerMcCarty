/*Project Euler - Problem 17
 * If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
 * 
 * If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
 * 
 * NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.
 * The use of "and" when writing out numbers is in compliance with British usage.
 */

using System;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sumOfWords = 0;
            
            string[] numWords = new string[1001];

            numWords[0] = "";
            numWords[1] = "one";
            numWords[2] = "two";
            numWords[3] = "three";
            numWords[4] = "four";
            numWords[5] = "five";
            numWords[6] = "six";
            numWords[7] = "seven";
            numWords[8] = "eight";
            numWords[9] = "nine";
            numWords[10] = "ten";
            numWords[11] = "eleven";
            numWords[12] = "twelve";
            numWords[13] = "thirteen";
            numWords[14] = "fourteen";
            numWords[15] = "fifteen";
            numWords[16] = "sixteen";
            numWords[17] = "seventeen";
            numWords[18] = "eighteen";
            numWords[19] = "nineteen";
            numWords[20] = "twenty";
            numWords[30] = "thirty";
            numWords[40] = "forty";
            numWords[50] = "fifty";
            numWords[60] = "sixty";
            numWords[70] = "seventy";
            numWords[80] = "eighty";
            numWords[90] = "ninety";
            numWords[100] = "hundred";
            numWords[101] = "onehundredand";
            numWords[201] = "twohundredand";
            numWords[301] = "threehundredand";
            numWords[401] = "fourhundredand";
            numWords[501] = "fivehundredand";
            numWords[601] = "sixhundredand";
            numWords[701] = "sevenhundredand";
            numWords[801] = "eighthundredand";
            numWords[901] = "ninehundredand";
            numWords[1000] = "onethousand";
            
            
            for (int i = 1; i <= 1000; i++)
            {
                if (i <= 20)
                {
                    sumOfWords += numWords[i].Length;
                }
                else if (i < 100)
                {
                    sumOfWords += numWords[i / 10 * 10].Length;
                    sumOfWords += numWords[i % 10].Length;
                }
                else if (i < 1000 && i % 100 == 0)
                {
                    sumOfWords += numWords[i / 100].Length;
                    sumOfWords += numWords[100].Length;
                }
                else if (i < 1000 && i / 10 % 10 != 1)
                {
                    sumOfWords += numWords[i / 100 * 100 + 1].Length;
                    sumOfWords += numWords[i / 10 % 10 * 10].Length;
                    sumOfWords += numWords[i % 10].Length;
                }
                else if (i < 1000 && i / 10 % 10 == 1)
                {
                    sumOfWords += numWords[i / 100 * 100 + 1].Length;
                    int tempVal = i;
                    while (tempVal > 100)
                    {
                        tempVal -= 100;
                    }

                    sumOfWords += numWords[tempVal].Length;
                }
                else if (i == 1000)
                {
                    sumOfWords += numWords[1000].Length;
                }
            }
            
            Console.WriteLine(sumOfWords);
        }
    }
}
