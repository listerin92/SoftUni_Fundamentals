using System;

namespace _04._Print_and_sum
{
    class Print_and_sum
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var last = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = first; i <= last; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
            
        }
    }
}
