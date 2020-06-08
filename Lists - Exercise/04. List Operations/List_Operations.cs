using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class List_Operations
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToList();

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "End")
            {
                List<string> splitMessages = commands.Split(' ').ToList();

                switch (splitMessages[0])

                {
                    case "Add":
                        Add(integers, splitMessages);
                        break;
                    case "Remove":
                        Remove(integers, splitMessages);
                        break;
                    case "Insert":
                        Insert(integers, splitMessages);
                        break;
                    case "Shift":
                        if (splitMessages[1] == "left")
                        {
                            ShiftLeft(integers, splitMessages);
                        }
                        else
                        {
                            ShiftRight(integers, splitMessages);
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", integers));
        }

        static void Add(List<int> integers, List<string> splitMessages)
        {
            int number = int.Parse(splitMessages[1]);
            integers.Add(number);
        }
        static void Remove(List<int> integers, List<string> splitMessages)
        {
            int index = int.Parse(splitMessages[1]);
            if ((index >= 0) && (index < integers.Count))
            {
                integers.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        static void Insert(List<int> integers, List<string> splitMessages)
        {
            int number = int.Parse(splitMessages[1]);
            int index = int.Parse(splitMessages[2]);
            if ((index >= 0) && (index < integers.Count))
            {
                integers.Insert(index, number);
            }
            else
            {
                Console.WriteLine("Invalid index");

            }
        }
        static void ShiftLeft(List<int> integers, List<string> splitMessages)
        {
            int count = int.Parse(splitMessages[2]);
            for (int i = 0; i < count; i++)
            {
                int temp = integers[0];
                integers.RemoveAt(0);
                integers.Add(temp);
            }
        }

        static void ShiftRight(List<int> integers, List<string> splitMessages)
        {
            int count = int.Parse(splitMessages[2]);

            for (int i = 0; i < count; i++)
            {
                int temp = integers[integers.Count - 1];
                integers.RemoveAt(integers.Count - 1);
                integers.Insert(0, temp);
            }
        }
    }
}