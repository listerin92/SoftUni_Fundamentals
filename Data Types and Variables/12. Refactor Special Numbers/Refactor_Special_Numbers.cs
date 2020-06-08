using System;

namespace _12._Refactor_Special_Numbers
{
    class Refactor_Special_Numbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            bool isItTrue = false;
            for (int i = 1; i <= number; i++)
            {
                num = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i /= 10;
                }
                isItTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", num, isItTrue);
                sum = 0;
                i = num;
            }

        }
    }
}
