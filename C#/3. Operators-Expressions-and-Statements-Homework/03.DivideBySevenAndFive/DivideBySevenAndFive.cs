using System;

namespace DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool divideBySevenAndFive = ((number % 7 == 0) && (number % 5 == 0));
            Console.WriteLine(divideBySevenAndFive);
        }
    }
}
