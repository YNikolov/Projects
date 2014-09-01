using System;

namespace IsThirdDigitSeven
{
    class IsThirdDigitSeven
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int dividerOne = (number / 100);
            bool isThirdDigitSeven = dividerOne % 10 == 7;            
            Console.WriteLine(isThirdDigitSeven);
        }
    }
}
