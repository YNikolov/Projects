using System;

namespace _15.BitExchange
{
    class  BitExchange
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint result = number;
            uint mask345 = 7 << 3;
            uint mask2456 = 7 << 24;

            uint bits345 = number & mask345;
            uint bits2456 = number & mask2456;

            result &= ~mask345;
            result &= ~mask2456;
            bits345 <<= (24 - 3);
            bits2456 = bits2456 >> (24 - 3);

            result |= bits345;
            result |= bits2456;
            Console.WriteLine(result);
        }

    }
}
