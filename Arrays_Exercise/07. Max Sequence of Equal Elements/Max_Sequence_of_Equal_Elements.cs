using System;
using System.Collections.Generic;
using System.Linq;


/*7.	Max Sequence of Equal Elements
Write a program that finds the longest sequence of equal elements in an array of integers.If several longest sequences exist, print the leftmost one.
Examples
Input   Output
2 1 1 2 3 3 2 2 2 1	2 2 2
1 1 1 2 3 1 3 3	1 1 1
4 4 4 4	4 4 4 4
0 1 1 5 2 2 6 3 3	1 1
*/


namespace _07._Max_Sequence_of_Equal_Elements
{
    class Max_Sequence_of_Equal_Elements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 1, maxCount = 0, number = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i-1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = arr[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{number} ");
            }
            
        }
    }
}
