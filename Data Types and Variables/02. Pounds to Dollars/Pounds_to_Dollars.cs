using System;

namespace _02._Pounds_to_Dollars
{
    class Pounds_to_Dollars
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dolars = pounds * 1.31m;
            Console.WriteLine($"{dolars:F3}");
        }
    }
}
