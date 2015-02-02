using System;

class CalculateNAndK
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int factorialK = K;
        int factorialN = 1;
        for (int i = N; i > 1; i--)
        {
            factorialN *= i;
            if (K > 1)
            {
                K--;
            }
            factorialK *= K;
        }
        int sumFactorial = factorialN / factorialK;
        Console.WriteLine(sumFactorial);
    }
}

