using System;

class CalcTheSum
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());
        int X = int.Parse(Console.ReadLine());
        double dividend = 1.00;
        double divider = 1.00;
        double sum = 1.00;

        for (int i = 1; i <= N; i++)
        {
            dividend *= i;
            divider *= X;
            sum = sum + (dividend / divider);
        }
        Console.WriteLine("S = {0:0.00000}", sum);
    }
}