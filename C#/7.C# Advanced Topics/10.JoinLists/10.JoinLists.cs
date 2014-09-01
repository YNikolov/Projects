using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split().Select(int.Parse);
            var secondLine = Console.ReadLine().Split().Select(int.Parse);

            List<int> firstList = new List<int>(firstLine);

            List<int> secondList = new List<int>(secondLine);

            List<int> unatedList = new List<int>();
            unatedList.AddRange(firstList);

            for (int i = unatedList.Count - 1; i >= 0; i--)
            {
                if (secondList.Contains(unatedList[i]))
                {
                    unatedList.RemoveAt(i);
                }
            }
            unatedList.AddRange(secondList);
            unatedList.Sort();

            PrintList(unatedList);
        }

        private static void PrintList(List<int> unionList)
        {
            foreach (var item in unionList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
