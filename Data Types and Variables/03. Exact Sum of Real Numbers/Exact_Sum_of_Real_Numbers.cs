using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Exact_Sum_of_Real_Numbers
    {
        static void Main(string[] args)
        {
            var numOfLines = int.Parse(Console.ReadLine());
            decimal total = 0;
            for (int i = 0; i < numOfLines; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                total += num;
            }
            Console.WriteLine(total);
        }
    }
}
