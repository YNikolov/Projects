using System;

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            int abcd = int.Parse(Console.ReadLine());
            int a = abcd / 1000;
            int b = (abcd / 100) % 10;
            int c = (abcd % 100) / 10;
            int d = abcd % 10;           
            int sum = a + b + c + d;
            Console.WriteLine(sum);
            int reversedOrder = (1000 * d) + (100 * c) + (10 * b) + a;
            Console.WriteLine(reversedOrder);
            int changeFirstDigitPosition = (1000 * d) + (100 * a) + (10 * b) + c;
            Console.WriteLine(changeFirstDigitPosition);
            int changeDigits = (1000 * a) + (100 * c) + (10 * b) + d;
            Console.WriteLine(changeDigits);


        }
    }
}
