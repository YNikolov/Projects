using System;

namespace _11.ExtractBitNumberThree
{
    class ExtractBitNumberThree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int extractedBit3 = n & mask;
            if (extractedBit3 == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
