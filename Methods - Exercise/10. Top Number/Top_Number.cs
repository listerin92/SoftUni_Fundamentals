using System;

namespace _10._Top_Number
{
    class Top_Number
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Print(input);
        }
        private static void Print(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsDigitSumDivisibleBy8(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
        private static bool IsDigitSumDivisibleBy8(int number)
        {
            int digitSum = 0;
            while (number > 0)
            {
                digitSum += number % 10;
                number /= 10;
            }

            if (digitSum % 8 == 0)
                return true;

            return false;
        }
        private static bool HasOddDigit(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                    return true;
                number /= 10;
            }

            return false;
        }
    }
}
