using System;

namespace _10._Multiplication_Table
{
    class Multiplication_Table
    {
        static void Main(string[] args)
        {
            int mult = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                var result = mult * i;
                Console.WriteLine($"{mult} X {i} = {result}");
            }
        }
    }
}
