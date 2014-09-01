using System;

namespace _10.PointInsideAndOutside
{
    class PointInsideAndOutside
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isInCircle = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5;
            bool isOutsideRectangle = x < -1 || x > 5 || y < -1 || y > 1;

            bool isInCircleAndOutsideRectangle = isInCircle && isOutsideRectangle;
            if (isInCircleAndOutsideRectangle)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
