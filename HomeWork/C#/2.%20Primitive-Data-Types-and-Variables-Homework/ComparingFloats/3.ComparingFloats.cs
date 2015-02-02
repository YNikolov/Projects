using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float eps = 0.000001f;            
            bool areEqual = (a - b) < eps;
            Console.WriteLine("Are number {0} and {1} equal?\n{2}", a, b, areEqual);
            
        }
    }
}
