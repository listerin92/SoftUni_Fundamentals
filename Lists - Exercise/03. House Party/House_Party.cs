using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class House_Party
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> messages = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                messages.Add(Console.ReadLine());
            }

            List<string> list = AddToLIst(messages);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        private static List<string> AddToLIst(List<string> messages)
        {
            List<string> list = new List<string>();

            foreach (var item in messages)
            {
                List<string> splitMessage = item.Split(' ', 2).ToList();
                string name = splitMessage[0];
                string messageText = splitMessage[1];

                if (messageText == "is going!")
                {

                    if (list.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    list.Add(name);
                }
                else
                {
                    if (!list.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    list.Remove(name);
                }
            }

            return list;
        }
    }
}
