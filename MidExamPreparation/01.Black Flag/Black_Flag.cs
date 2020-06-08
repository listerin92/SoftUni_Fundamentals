using System;
using System.Transactions;
// 100 ot 100
namespace _01_BlackFlag
{
    class BlackFlag
    {
        static void Main(string[] args)
        {
            uint days = uint.Parse(Console.ReadLine());
            byte dailyPlunder = byte.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            uint currentDay = 1;
            double totalPlunder = 0;

            while (currentDay <= days)
            {
                totalPlunder += dailyPlunder;

                if (currentDay % 3 == 0)
                {
                    double fiftyPercent = dailyPlunder * 0.5;
                    totalPlunder += fiftyPercent;
                }
                if (currentDay % 5 == 0)
                {
                    double thirtyPercent = totalPlunder * 0.3;
                    totalPlunder -= thirtyPercent;
                }
                currentDay++;
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:0.00} plunder gained.");
            }
            else if (totalPlunder < expectedPlunder)
            {
                double percentage = (totalPlunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentage:0.00}% of the plunder.");
            }
        }
    }
}
