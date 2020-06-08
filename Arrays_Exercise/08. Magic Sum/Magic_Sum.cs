using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Magic_Sum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int givenNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (givenNumber == arr[i] + arr[j])
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }
                }

            }

        }
    }
}
