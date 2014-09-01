using System;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool isOdd = (number % 2 != 0);
            Console.WriteLine(isOdd);
        }
    }
}
