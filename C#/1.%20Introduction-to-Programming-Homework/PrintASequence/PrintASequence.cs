using System;

namespace PrintASequence
{
    class PrintASequence
    {
        static void Main()
        {
            for (int i = 2; i < 12; i++)
            {                
                {
                    Console.WriteLine(i % 2 == 0 ? i : -i);
                }      
            }
        }
    }
}
