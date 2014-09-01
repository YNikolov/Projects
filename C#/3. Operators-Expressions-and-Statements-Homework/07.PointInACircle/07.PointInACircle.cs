using System;

namespace _07.PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool isPointInCircle = Math.Sqrt(x * x + y * y) <= 2;
            Console.WriteLine(isPointInCircle);
        }
    }
}
