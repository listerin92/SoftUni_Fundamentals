using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _06._List_Manipulation_Basics
{
    class List_Manipulation_Basics
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;
            StringBuilder print = new StringBuilder();
            bool changes = false;

            while ((input = Console.ReadLine()) != "end")
            {
                var result = input.Split(" ").ToList();
                switch (result[0])
                {
                    case "Contains":
                        int value = int.Parse(result[1]);
                        print.Append(Contains(value, numbers) + "\n");
                        changes = true;
                        break;
                    case "PrintEven":
                        print.Append(PrintEven(numbers) + "\n");
                        changes = true;
                        break;
                    case "PrintOdd":
                        print.Append(PrintOdd(numbers) + "\n");
                        changes = true;
                        break;
                    case "GetSum":
                        print.Append(GetSum(numbers) + "\n");
                        changes = true;
                        break;
                    case "Filter":
                        string sign = result[1];
                        int filterValue = int.Parse(result[2]);
                        print.Append(Filter(numbers, sign, filterValue) + "\n");
                        changes = true;
                        break;
                    default:
                        break;
                }
            }

            if (changes)
            {
                Console.WriteLine(print.Remove(print.Length - 1, 1));
            }
        }

        private static string Filter(List<int> numbers, string sign, int value)
        {
            List<int> newNumbers = new List<int>();
            switch (sign)
            {
                case "<":
                    newNumbers = numbers.Where(num => num < value).ToList();
                    break;
                case ">":
                    newNumbers = numbers.Where(num => num > value).ToList();
                    break;
                case ">=":
                    newNumbers = numbers.Where(num => num >= value).ToList();
                    break;
                case "=<":
                    newNumbers = numbers.Where(num => num <= value).ToList();
                    break;
                default:
                    break;
            }
            string str = string.Empty;
            return str = string.Join(" ", newNumbers);
        }

        private static string GetSum(List<int> numbers)
        {

            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum.ToString();
        }
        private static string PrintOdd(List<int> numbers)
        {
            StringBuilder str = new StringBuilder();
            foreach (var item in numbers)
            {
                if (item % 2 == 1)
                {
                    str.Append(item + " ");
                }
            }

            return str.ToString();
        }

        private static string PrintEven(List<int> numbers)
        {
            StringBuilder str = new StringBuilder();
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    str.Append(item + " ");
                }
            }

            return str.ToString();
        }

        private static string Contains(int value, List<int> numbers)
        {
            if (numbers.Contains(value))
            {
                return "Yes";
            }
            else return "No such number";

        }
    }
}
