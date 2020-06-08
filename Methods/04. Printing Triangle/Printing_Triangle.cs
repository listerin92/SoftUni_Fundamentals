using System;

namespace _04._Printing_Triangle
{
    class Printing_Triangle
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
        static void PrintTriangle(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                PrintLine(1,i);
            }

            for (int i = input-1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

    }
}
