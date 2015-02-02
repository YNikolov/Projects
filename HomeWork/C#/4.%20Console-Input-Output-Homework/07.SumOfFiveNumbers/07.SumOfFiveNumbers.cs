using System;

namespace _07.SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main()
        {
           
           string inputNumbers = Console.ReadLine();
           string[] allNumbers = inputNumbers.Split(' ');
           double sum = 0;
           for (int i = 0; i < allNumbers.Length; i++)
           {               
                sum += double.Parse(allNumbers[i]);
           }
           Console.WriteLine(sum);           
        }
    }
}
