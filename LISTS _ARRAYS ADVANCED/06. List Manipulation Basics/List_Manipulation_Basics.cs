using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class List_Manipulation_Basics
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var result = input.Split(" ").ToList();
                switch (result[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(result[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(result[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(result[1]));
                        break;
                    case "Insert":
                        var num = int.Parse(result[1]);
                        var index = int.Parse(result[2]);
                        numbers.Insert(index, num);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

        }

    }
}
