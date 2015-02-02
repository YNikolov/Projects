using System;

namespace _04.Rectangles
{
    class Rectangles
    {

        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = (width + height) * 2;
            double area = width * height;
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
        }
    }
}
