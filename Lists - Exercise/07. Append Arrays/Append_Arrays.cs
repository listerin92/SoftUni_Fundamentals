using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Append_Arrays
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine()
                                            .Split('|')
                                            .Where(s => !string.IsNullOrEmpty(s))
                                            .ToList();
            List<int> newList = new List<int>();
            foreach (var item in arrays)
            {
                List<int> arraysOfInts = item.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                arraysOfInts.Reverse();
                foreach (var itm in arraysOfInts)
                {
                    newList.Add(itm);
                }
            }
            newList.Reverse();
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
