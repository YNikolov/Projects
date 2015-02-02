using System;

namespace _05.SortingNumbers
{

    class SortingNumbers
    {

        static int[] Sort(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int biggerNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = biggerNum;
                    }
                }
            }

            return numbers;
        }

        static void PrintNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0}", numbers[i]);
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            numbers = Sort(numbers);

            PrintNumbers(numbers);
        }
    }
}