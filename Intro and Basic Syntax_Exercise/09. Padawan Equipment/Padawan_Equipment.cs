using System;

namespace _09._Padawan_Equipment
{
    class Padawan_Equipment
    {
        static void Main(string[] args)
        {
            double AmountOfMoney = double.Parse(Console.ReadLine());
            byte StudentCount = byte.Parse(Console.ReadLine());
            double PriceOfLightSabers = double.Parse(Console.ReadLine());
            double PriceOfRobes = double.Parse(Console.ReadLine());
            double PriceOfBelts = double.Parse(Console.ReadLine());

            int everySixt = StudentCount / 6;
            double tenpercentExact = StudentCount*0.1;
            byte tenpercentRound = (byte)Math.Ceiling(tenpercentExact);
            double cost = PriceOfLightSabers * (StudentCount+ tenpercentRound)
                + PriceOfRobes * StudentCount + PriceOfBelts * (StudentCount- everySixt);
            var neededMoney = cost - AmountOfMoney;
            if (AmountOfMoney >= cost)
            {
                Console.WriteLine($"The money is enough - it would cost {cost:0.00}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {neededMoney:0.00}lv more.");
            }
        }
    }
}
