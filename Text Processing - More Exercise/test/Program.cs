using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 100;
            int[] arr = new int[N];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, arr.Length);
            }
            Array.Sort(arr);
            int count = pairWithSumXSmart(12, arr);
            Console.WriteLine(count);
        }
        public static int pairWithSumXSmart(int X,  int[] a)
        {
            int ans = 0;
            for (int i = 0, j = a.Length - 1; i < j; i++) 
            {
                while (i < j && (a[i] + a[j]) > X) 
                {
                    j--;
                }

                if (i < j && a[i] + a[j] == X)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}