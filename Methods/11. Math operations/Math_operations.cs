using System;

namespace _11._Math_operations
{
    class Math_operations
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @opearator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double result = Calculate(a, @opearator, b);
            Console.WriteLine(result);
        }

        private static double Calculate(int a, string @operator, int b)
        {
            double result = 0;
            switch (@operator)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
