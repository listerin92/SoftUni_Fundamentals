using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Zig_Zag_Arrays
    {
        static void Main(string[] args)
        {
            int initial = int.Parse(Console.ReadLine());
            int[] arr1 = new int[initial];
            int[] arr2 = new int[initial];
            
            for (int i = 0; i < initial; i++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i%2==0)
                {
                    arr1[i] = line[0];
                    arr2[i] = line[1];
                }
                else
                {
                    arr1[i] = line[1];
                    arr2[i] = line[0];
                }
                
            }
            
           
                Console.Write(string.Join(" ", arr1));
                Console.WriteLine();
                Console.Write(string.Join(" ", arr2));
            
        }
    }
}
