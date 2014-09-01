using System;

namespace _03.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());           
            Console.WriteLine("{0:F2}", Math.PI * 2 * r);
            Console.WriteLine("{0:F2}", Math.PI * r * r);	       
        }
    }
}
