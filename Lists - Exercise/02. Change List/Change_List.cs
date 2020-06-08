using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Change_List
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "end")
            {
                List<string> oneCommand = commands.Split().ToList();

                switch (oneCommand[0])

                {
                    case "Delete":
                        int element = int.Parse(oneCommand[1]);
                        ints.Remove(element);
                    break;
                    case "Insert":
                        int index = int.Parse(oneCommand[2]);
                        int insertElement = int.Parse(oneCommand[1]);
                        ints.Insert(index, insertElement);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", ints));
        }
    }
}
