using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Remove_Negatives_and_Reverse
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            /*      for (int i = 0; i < numbers.Count; i++)
                  {
                      if (numbers[i] < 0)
                      {
                          numbers.RemoveAt(i);
                          i--;
                      }
                  }
                  //    slower on judge
            */

            /*     List<int> newPositive = new List<int>();

                 foreach (var item in numbers)
                 {
                     if (item > 0)
                     {
                         newPositive.Add(item);
                     }
                     // pass but found RemoveAll
                 }*/
            numbers.RemoveAll(n => n < 0);

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
