using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        int a = 3;
        int b = 4;
        int c = 5;
        int d = 6;
        int e = 7;
        int f = 8;
        int g = 9;
        int h = 10;

        for (int i = 2; i < 15; i++)
        {
            if (i > 1 && i < 11)
            {
                Console.WriteLine("{0}{1} {2}{3} {4}{5} {6}{7}", i, (char)a, i, (char)b, i, (char)c, i, (char)d);
            }
            else
            {
                for (int j = i; j < i + 1; j++)
                    switch (i)
                    {
                        case 11: Console.WriteLine("Q{0} Q{1} Q{2} Q{3}", (char)a, (char)b, (char)c, (char)d); break;
                        case 12: Console.WriteLine("A{0} A{1} A{2} A{3}", (char)a, (char)b, (char)c, (char)d); break;
                        case 13: Console.WriteLine("J{0} J{1} J{2} J{3}", (char)a, (char)b, (char)c, (char)d); break;
                        case 14: Console.WriteLine("K{0} K{1} K{2} K{3}", (char)a, (char)b, (char)c, (char)d); break;
                    }
            }
        }
    }
}


