using System;

class QuadraticEquation
{
    static void Main()
    {        
        double a = double.Parse(Console.ReadLine());     
        double b = double.Parse(Console.ReadLine());        
        double c = double.Parse(Console.ReadLine());
        double discriminant = (b * b) - (4 * (a * c));     
        if (discriminant < 0)
        {
            Console.WriteLine("No real roots");
            return;                                 
        }
        else if (discriminant == 0)
        {
            double x = -b / 2 / a;
            Console.WriteLine("Double root x1 = x2 = {0}", x);
        }
        else
        {
            double x1 = (-b - Math.Sqrt(discriminant)) / 2 / a; 
            double x2 = (-b + Math.Sqrt(discriminant)) / 2 / a; 
            Console.WriteLine("{0}{1}", x1, x2);
        }
    }
}

