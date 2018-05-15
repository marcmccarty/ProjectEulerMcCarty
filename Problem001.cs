using System;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sumOfMultiples = 0;
            
            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumOfMultiples += i;
                }
            }
            
            Console.WriteLine(sumOfMultiples);
            Console.ReadLine();
        }
    }
}
