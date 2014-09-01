using System;
using System.Numerics;

namespace _07.CalculateNKFactorial
{
    class CalculateNKFactorial
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int varK = K;
            BigInteger  factorialK = K;           
            BigInteger factorialN = 1;
            BigInteger nMinusKfactorial = N - K;
            BigInteger varNMinusK = nMinusKfactorial;
            for (int i = N; i > 1; i--)
            {
                factorialN *= i;
                if (varK > 1)
                {
                    varK--;
                }
                factorialK *= varK;
                if (varNMinusK > 1)
                {
                    varNMinusK--;
                }
                nMinusKfactorial *= varNMinusK;
            }
            BigInteger result = factorialN / (factorialK * nMinusKfactorial);            
            Console.WriteLine(result);
        }
    }
}
