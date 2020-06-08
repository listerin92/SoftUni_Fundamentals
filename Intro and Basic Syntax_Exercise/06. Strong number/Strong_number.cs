using System;

namespace _06._Strong_number
{
    class Strong_number
    {
        public static int Factorial_Recursion(int number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
                return number * Factorial_Recursion(number - 1);
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string tempNum = num.ToString();
            var sum = 0;

            foreach (char item in tempNum)
            {
                sum += Factorial_Recursion(int.Parse(item.ToString()));
            }
            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");

        }
    }
}
