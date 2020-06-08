using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Largest_3_Numbers
    {
        static void Main(string[] args)
        {
            var integerList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sortedList = integerList.OrderByDescending(o => o).Take(3);
            Console.WriteLine(string.Join(" ", sortedList));
        }
    }
}
