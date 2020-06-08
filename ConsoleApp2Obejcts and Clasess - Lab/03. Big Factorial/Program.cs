using System;
using System.Linq;
using System.Numerics;

namespace _03._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger output  = CalcFactorial(input);
            Console.WriteLine(output);
        }

        private static BigInteger CalcFactorial(int fact)
        {
            BigInteger output = 1;
            for (int i = fact; i >= 1; i--)
            {
                output *= i;
            }
            return output;
        }
    }
}
