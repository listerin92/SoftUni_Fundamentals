using System;
using System.Globalization;

namespace _13._Holidays_Between_Two_Dates
{
    class Holidays_Between_Two_Dates
    {
        static void Main(string[] args)
        {
            string[] allowedFormats = { "dd.MM.yyyy", "d.MM.yyyy", "dd.M.yyyy", "d.M.yyyy" };
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                allowedFormats, CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                allowedFormats, CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date=date.AddDays(1))
            { 
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
            }
            Console.WriteLine(holidaysCount);

        }
    }
}
