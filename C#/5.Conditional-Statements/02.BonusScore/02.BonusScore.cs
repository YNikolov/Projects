using System;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            short n = short.Parse(Console.ReadLine());
           
            if (n >= 1 && n <= 3)
                {
                    Console.WriteLine("{0}", n * 10);
                }
            else if (n >= 4 && n <= 6)
            {
                Console.WriteLine("{0}", n * 100);
            }
            else if (n >= 7 && n <= 9)
            {
                Console.WriteLine("{0}", n * 1000);
            }
            else if (n == 0 || n > 9)
            {
                Console.WriteLine("Invalid score!");
            }
        }
    }
}
