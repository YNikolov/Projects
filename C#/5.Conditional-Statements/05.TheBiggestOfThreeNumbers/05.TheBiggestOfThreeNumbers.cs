using System;

namespace _06.TheBiggestOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double biggest;
            if (a > b && a > c)
            {
                biggest = a;
                Console.WriteLine(biggest);   
            }
            else if (b > a && b > c)
            {
                biggest = b;
                Console.WriteLine(biggest);
            }
            else
            {
                biggest = c;
                Console.WriteLine(biggest);
            }
            
            
        }
    }
}
