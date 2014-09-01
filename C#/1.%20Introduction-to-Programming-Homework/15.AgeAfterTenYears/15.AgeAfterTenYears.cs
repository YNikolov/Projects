using System;

namespace _15.AgeAfterTenYears
{
    class Program
    {
        static void Main()
        {
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("After ten years my age will be: {0}", age + 10);
        }
    }
}
