using System;

namespace _13.CheckBitPosition
{
    class CheckBitPosition
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int i = 1;
            int mask = i << p;
            bool isOne = (n & mask) != 0;
            Console.WriteLine(isOne);                       
        }
    }
}