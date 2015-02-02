using System;

namespace _11.NumberAsWords
{

    class NumberAsWords
    {
        static string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen",
                                "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred" };

        static void Main()
        {
            ushort number;
            bool isNum = ushort.TryParse(Console.ReadLine(), out number);

            if (isNum)
            {
                if (number > 99 && number < 1000)
                {
                    Console.WriteLine(number / (number % 1000 / 100) == 100 ? words[number % 1000 / 100] + " " +
                        words[words.Length - 1] : words[number % 1000 / 100] + " " + words[words.Length - 1] + " " +
                        (number % 100 / 10 == 0 ? "and" + " " + words[number % 10] : (number % 100 < 21 ? "and " +
                        words[(number % 100)] : "and " + words[18 + (number % 100 / 10)] + " " + (number % 10 != 0 ? words[number % 10] : " "))));
                }
                else if (number < 100)
                {
                    Console.WriteLine(number % 100 / 10 == 0 ? words[number % 10] :
                      (number < 21 ? words[number] : words[18 + (number % 100 / 10)] + " " + (number % 10 != 0 ? words[number % 10] : " ")));
                }
            }
        }
    }
}
