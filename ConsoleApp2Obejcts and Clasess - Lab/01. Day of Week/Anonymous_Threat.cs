using System;
using System.Globalization;

namespace _08._Anonymous_Threat
{
    class Anonymous_Threat
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();
            DateTime input = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(input.DayOfWeek);
        }
    }
}