using System;

namespace _02._Division
{
    class Division
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int devision = 0;
            int[] arr = new int[5] { 2, 3, 6, 7, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (num % arr[i] == 0)
                    devision = arr[i];
            }

            if (devision != 0)
            {
                Console.WriteLine("The number is divisible by {0}", devision);
            }
            else
                Console.WriteLine("Not divisible");

        }
    }
}
