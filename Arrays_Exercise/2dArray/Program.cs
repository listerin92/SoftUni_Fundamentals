using System;

namespace _2dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5,5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        arr[i, j] = 5;
                    }
                    else
                    {
                        arr[i, j] = 1;
                    }
                    
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
