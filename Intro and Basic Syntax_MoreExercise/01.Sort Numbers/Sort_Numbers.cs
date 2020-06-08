using System;

namespace _01.Sort_Numbers
{
    class Sort_Numbers
    {
        static void Main(string[] args)
        {
            int[] input = new int[3];
            for (int i = 0; i < 3; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(input);
            Array.Reverse(input);

            for (int j = 0; j < input.Length; j++)
            {
                Console.WriteLine($"{input[j]}");
            }
        }
    }
}
