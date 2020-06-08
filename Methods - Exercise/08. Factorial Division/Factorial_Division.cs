using System;

namespace _08._Factorial_Division
{
    class Factorial_Division
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            double result = Factorial(first) / Factorial(second);
            Console.WriteLine("{0:0.00}", result);
        }

        private static double Factorial(double input)
        {
            double simpleFac = input;
            if (simpleFac == 0)
            {
                return simpleFac = 1;
            }
            for (double i = input-1; i >= 1; i--)
            {
                simpleFac *= i;
            }
            return simpleFac;
        }

    }
}
