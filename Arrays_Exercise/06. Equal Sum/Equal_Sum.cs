using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Equal_Sum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0, rightSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                rightSum += arr[i];
                
            }

            for (int i = 0; i < arr.Length; i++)
            {
                rightSum -= arr[i];
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSum += arr[i];
            }
            Console.WriteLine("no");
        }
    }
}
