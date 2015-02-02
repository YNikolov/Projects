using System;

namespace _16.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int n = 1002;
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("-" + i);
                }

            }
        }
    }
}
