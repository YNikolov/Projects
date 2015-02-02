using System;

namespace _14.ModifyABit
{
    class ModifyABit
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = v << p;
            n = n & (~(1 << p));
            int modifiedNumber = n | mask;
            Console.WriteLine(modifiedNumber);
        }
    }
}
