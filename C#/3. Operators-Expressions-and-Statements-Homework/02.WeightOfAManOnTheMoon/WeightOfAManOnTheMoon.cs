using System;

namespace _02.WeightOfAManOnTheMoon
{
    class WeightOfAManOnTheMoon
    {
        static void Main()
        {
            double weightOnTheEarth = double.Parse(Console.ReadLine());
            double weightOnTheMoon = weightOnTheEarth * 0.17;
            Console.WriteLine(weightOnTheMoon);

        }
    }
}
