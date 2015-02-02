using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrimeChecker
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            CheckIsPrime(n);
        }
        private static void CheckIsPrime(long n)
        {

            bool isPrime = true;
            if (n <= 1)
            {
                isPrime = false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }

            }
            Console.WriteLine(isPrime);
        }
    }
}
