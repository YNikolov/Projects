using System;

namespace _05.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            Console.Write("|{0:}|{1}|", a.ToString("X").PadRight(10, ' '),
                Convert.ToString(a, 2).PadLeft(10, '0'));
            if (b % 1 == 0)
            {
                Console.Write("{0,10}|", b); 
            }
            else
            {
                Console.Write("{0}|", b.ToString("F2").PadLeft(10, ' '));  
            }
            if (c % 1 == 0)
            {
                Console.WriteLine("{0,-10}|", c);
            }
            else
            {
                Console.WriteLine("{0}|", c.ToString("F3").PadRight(10, ' '));
            }
        }
    }
}
