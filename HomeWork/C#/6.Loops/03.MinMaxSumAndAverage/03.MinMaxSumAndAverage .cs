using System;
using System.Linq;

namespace _03
{
    class MinMaxSumAndAverage
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("min = {0}", numbers.Min());
            Console.WriteLine("max = {0}", numbers.Max());
            Console.WriteLine("sum = {0}", numbers.Sum());
            Console.WriteLine("avg = {0:0.00}", numbers.Average());

        }
    }
}
