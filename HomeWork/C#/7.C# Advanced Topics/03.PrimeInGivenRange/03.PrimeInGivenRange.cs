using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrimeInGivenRange
{
    class Program
    {
        public static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> primes = FindPrimesInRange(startNum, endNum);

            foreach (var item in primes)
            {
                Console.WriteLine("{0} ", item);
            }

        }
        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primesList = new List<int>();

            for (int num = startNum; num <= endNum; num++)
            {
                bool prime = true;
                double numSqrt = Math.Sqrt(num);

                for (int div = 2; div <= numSqrt; div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {

                    primesList.Add(num);
                }
            }
            return primesList;
        }
    }
}
