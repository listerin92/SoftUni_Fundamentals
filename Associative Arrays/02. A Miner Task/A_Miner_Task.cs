using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class A_Miner_Task

    {
        static void Main(string[] args)
        {

            string command = string.Empty;
            Dictionary<string, long> resQuantity = new Dictionary<string, long>();
            int lineCount = 1;
            string previousCommand = "";
            while ((command = Console.ReadLine()) != "stop")
            {
                if (lineCount % 2 == 1)
                {
                    if (!resQuantity.ContainsKey(command))
                    {
                        resQuantity.Add(command, 0);
                    }
                }
                else
                {
                    resQuantity[previousCommand] += long.Parse(command);
                }
                previousCommand = command;
                lineCount++;
            }
            foreach (var res in resQuantity)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
