using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Merging_Lists
    {
        /*
          You are going to receive two lists with numbers. Create a result list, which contains the numbers from both of the lists. 
          The first element should be from the first list, the second from the second list and so on. 
          If the length of the two lists are not equal, just add the remaining elements at the end of the list.

            Example

            Input	                    Output
            3 5 2 43 12 3 54 10 23
            76 5 34 2 4 12	            3 76 5 5 2 34 43 2 12 4 3 12 54 10 23

            76 5 34 2 4 12
            3 5 2 43 12 3 54 10 23	    76 3 5 5 34 2 2 43 4 12 12 3 54 10 23

            Hint
            •	Read the two lists
            •	Create a result list
            •	Start looping through them until you reach the end of the smallest one
            •	Finally add the remaining elements (if there are any) to the end of the list

         */


        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(MergeLists(firstList, secondList));

        }

        private static string MergeLists(List<int> firstList, List<int> secondList)
        {
            var firstListCount = firstList.Count;
            var secondListCount = secondList.Count;
            var largestListCount = Math.Max(firstList.Count, secondList.Count);
            List<int> mergedList = new List<int>(firstListCount + secondListCount);

            string output = string.Empty;

            for (int i = 0; i < largestListCount; i++)
            {
                if (i < firstListCount)
                {
                    mergedList.Add(firstList[i]);
                }
                if (i < secondListCount)
                {
                    mergedList.Add(secondList[i]);
                }
            }
            return string.Join(" ", mergedList);
        }

    }
}
