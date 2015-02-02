using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");
        DateTime inputTime;
        DateTime beerTimeAfter = DateTime.Parse("1:00 PM");
        DateTime beerTimeBefore = DateTime.Parse("3:00 AM");
        string enteredTime = Console.ReadLine();

        if (DateTime.TryParseExact(enteredTime, "h:mm tt", enUS,
                                    DateTimeStyles.None, out inputTime))
        {
            if (inputTime >= beerTimeAfter || inputTime < beerTimeBefore)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

