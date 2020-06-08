using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Smallest_of_Three_Numbers
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int result = SmallestFromThree(first, second, third);
            Console.WriteLine(result);
        }
        private static int SmallestFromThree(int first, int second, int third)
        {
            if (first < second)
            {
                if (first < third)
                {
                    return first;
                }
                else return third;
            }
            else if (first < third)
            {
                if (first < second)
                {
                    return first;
                }
                else return second;
            }
            else if (third < second)
            {
                return third;
            }
            else return second;
        
        }
    }
}

