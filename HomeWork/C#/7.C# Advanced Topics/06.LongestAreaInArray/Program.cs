//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06.LongestAreaInArray
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] text = new string[6];
//            int currentCounter = 0;
//            int maxCounter = 0;
//            int even = 0;
//            string[] longestArea = new string[6];

//            for (int i = 0; i < 6; i++)
//            {
//                string inputLine = Console.ReadLine();
//                text[i] = inputLine;
//            }

//            for (int i = 0; i < text.Length; i++)
//            {
//                for (int j = 0; j < text.Length; j++)
//                {
//                    if (text[j] == text[i])
//                    {                        
//                        currentCounter++;
//                        if (currentCounter > maxCounter)
//                        {
//                            longestArea[i] = text[j];
//                            maxCounter = currentCounter;
//                        }
//                        else if (currentCounter == maxCounter)
//                        {
//                            even = currentCounter;
//                        }
//                    }
//                }
//                currentCounter = 0;
//            }
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestAreaInArray
{
    static void Main()
    {
        int arrayLenght = int.Parse(Console.ReadLine());
        string[] words = new string[arrayLenght];

        for (int i = 0; i < words.Length; i++)
        {
            string arrayElement = Console.ReadLine();
            words[i] = arrayElement;
        }

        int startIndex = 0;
        int lenghtCount = 1;
        int currentCount = 1;

        for (int i = 0; i < words.Length - 1; i++) //could start on index 1 and check current with previous elements
        {
            if (words[i] == words[i + 1])
            {
                currentCount++;

                if (currentCount > lenghtCount)
                {
                    lenghtCount = currentCount;
                    startIndex = (i + 1) - (lenghtCount - 1);
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        Console.WriteLine(lenghtCount);
        for (int i = 0; i < lenghtCount; i++)
        {
            Console.WriteLine(words[startIndex + i]);
        }
    }
}

