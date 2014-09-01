using System;

namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    result++;  
                }
            }
            Console.WriteLine(result);
        }
    }
}
