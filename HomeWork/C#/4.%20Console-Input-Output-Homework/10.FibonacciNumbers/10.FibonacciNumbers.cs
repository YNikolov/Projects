using System;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            int one = 1;
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(result);
                int copiedResult = result;
                result = one;
                one = copiedResult + one;
            }
        }
    }
}
