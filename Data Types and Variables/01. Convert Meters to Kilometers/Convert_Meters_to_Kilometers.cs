using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Convert_Meters_to_Kilometers
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal km = meters / 1000;
            Console.WriteLine($"{km:F2}");
        }
    }
}
