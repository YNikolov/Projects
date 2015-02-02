using System;

class Fibonacci
{

    static void Main(string[] args)
    {        
        int number = Convert.ToInt32(Console.ReadLine());
        FibonacciNumbers(0, 1, 1, number);
    }

    public static void FibonacciNumbers(int a, int b, int counter, int number)
    {
        Console.WriteLine(a);
        if (counter < number)
        {
            FibonacciNumbers(b, a + b, counter + 1, number);
        }
    }

}