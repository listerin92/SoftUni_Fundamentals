using System;
using System.Collections.Generic;

namespace _01._Day_of_Week
{
    class Day_of_Week
    {
        static void Main(string[] args)
        {

            List<DayOfWeek> daysOfWeek = 
                new List<DayOfWeek>() { DayOfWeek.Sunday, 
                                        DayOfWeek.Monday, 
                                        DayOfWeek.Tuesday, 
                                        DayOfWeek.Wednesday, 
                                        DayOfWeek.Thursday, 
                                        DayOfWeek.Friday, 
                                        DayOfWeek.Saturday, 
                                        DayOfWeek.Sunday };

            int day = int.Parse(Console.ReadLine());

            if (day > 0 && day < 8)
            {
                Console.WriteLine(daysOfWeek[day]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
