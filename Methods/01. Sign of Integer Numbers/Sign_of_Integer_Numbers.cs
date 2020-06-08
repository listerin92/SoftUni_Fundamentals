using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Sign_of_Integer_Numbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(SignCheck(input));
        }

        static string SignCheck(int number)
        {
            string output = String.Empty;
            if (number > 0)
            {
                return output = $"The number {number} is positive.";
            }
            else if (number < 0)
            {
                return output = $"The number {number} is negative.";
            }
            return output = $"The number {number} is zero.";
        }
    }
}
