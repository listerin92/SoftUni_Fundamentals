using System;

namespace _09._Spice_Must_Flow
{
    class Spice_Must_Flow
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());
            uint numberOfDays = 0;
            uint finalYield = 0u;
            uint tempYield = startingYield;
            while (tempYield >= 100)
            {
                finalYield += (tempYield - 26);
                tempYield -= 10;
                numberOfDays++;
            }
            if (tempYield > 26 && numberOfDays>0)
            {
                finalYield -= 26;
            }

            Console.WriteLine(numberOfDays);
            Console.WriteLine(finalYield);

        }
    }
}
