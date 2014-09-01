using System;

namespace _04.NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double greater = Math.Max(a, b);
            Console.WriteLine(greater);
        }
    }
}
