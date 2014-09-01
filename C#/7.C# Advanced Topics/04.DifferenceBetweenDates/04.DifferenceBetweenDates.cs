using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DatesDifference
{
    static TimeSpan DaysDifference(DateTime startDate, DateTime endDate)
    {
        TimeSpan days = endDate - startDate;

        return days;
    }

    static void Main()
    {
        CultureInfo bgBG = new CultureInfo("bg-BG");

        try
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", bgBG);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", bgBG);

            Console.WriteLine(DaysDifference(startDate, endDate).Days);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid date! Dates must be in format dd.MM.yyyy.");
        }
    }
}

