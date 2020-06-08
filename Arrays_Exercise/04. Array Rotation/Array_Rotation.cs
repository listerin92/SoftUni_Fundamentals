using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Array_Rotation
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());
            int realRotations = rotation % arr.Length;
            for (int i = 0; i < realRotations; i++)
            {
                var temp = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = temp;
            }
            Console.WriteLine($"{string.Join(" ", arr)}");
        }
    }
}
