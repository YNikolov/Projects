using System;

namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte number = 0;
            for (byte row = 1; row <= n; row++)
            {
                number = row;
                for (byte col = 0; col < n; col++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
