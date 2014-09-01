using System;

class TheASCIITable
{
    static void Main()
    {
        for (int i = 0; i <= 127; i++)
        {
            char symbol = (char)i;
            Console.WriteLine("{0}: {1}", i, symbol);
        }
    }
}


