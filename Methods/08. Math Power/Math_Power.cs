using System;

namespace _08._Math_Power
{
    class Math_Power
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, int power)
        {
            double result = 0d;
            result = Math.Abs(number);
            for (int i = 1; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
