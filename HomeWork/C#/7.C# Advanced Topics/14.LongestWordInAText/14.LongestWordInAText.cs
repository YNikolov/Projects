using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestWordInAText
{
    class LongestWordInAText
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            FindLongestWord(input);
        }

        private static void FindLongestWord(string input)
        {            
            string[] text = input.Split(new[] { ' ', '.' });
            var longestWord = text.OrderByDescending(w => w.Length).First();
            Console.WriteLine(longestWord);
        }
    }
}