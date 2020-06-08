using System;

namespace _05._Add_and_Subtract
{
    class Add_and_Subtract
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int FinalResult = Substract(Sum(first, second), third);
            Console.WriteLine(FinalResult);
        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }

        private static int Substract(int first, int third)
        {
            return first - third;
        }

    }
}
