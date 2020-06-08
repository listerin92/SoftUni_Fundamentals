using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Top_Integers
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length-1; i++)
            {
                int tempTop = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (tempTop <= arr[j])
                    {
                        break;
                    }
                    else if (j == arr.Length - 1)
                    {
                        Console.Write($"{tempTop} ");
                    }
                }
            }
         Console.Write($"{arr[arr.Length - 1]}");
        }
    }
}
