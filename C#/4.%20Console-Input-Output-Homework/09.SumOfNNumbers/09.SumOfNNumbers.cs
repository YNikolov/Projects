using System;

namespace _09.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double nNumbers = double.Parse(Console.ReadLine());
                sum += nNumbers;
            }
            Console.WriteLine(sum);

        }
    }
}
