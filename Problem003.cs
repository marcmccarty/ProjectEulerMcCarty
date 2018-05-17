using System;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Arbitrarily large number
            double ourNum = 600851475143;

            double highestPossibleFactor = Math.Sqrt(ourNum);

            double maxFactor = 0;

            for (int i = 2; i < (int)highestPossibleFactor; i++)
            {
                bool prime = true;
                double highestPFPrime = Math.Sqrt(i);

                for (int j = 2; j < (int)highestPFPrime; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                    }
                }

                if (prime && (ourNum % i == 0))
                {
                    maxFactor = i;
                }
            }
            
            Console.WriteLine(maxFactor);
            Console.ReadLine();
        }
    }
}
