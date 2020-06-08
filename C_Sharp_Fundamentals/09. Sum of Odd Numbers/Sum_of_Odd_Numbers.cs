using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Sum_of_Odd_Numbers
    {
        static void Main(string[] args)
        {
            byte odd = byte.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= odd; i++)
            {

                Console.WriteLine("{0}", (2 * i) - 1);
                sum += (2 * i) - 1;

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
