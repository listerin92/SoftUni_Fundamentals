using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Treasure_Hunt
{ //70 ot 100
    class Treasure_Hunt
    {
        static void Main(string[] args)
        {
            List<string> initialLootChest = Console.ReadLine().Split('|').ToList();
            List<string> stealItems = new List<string>();

            string commandLine = string.Empty;
            while ((commandLine = Console.ReadLine()) != "Yohoho!")
            {
                string[] commandSplit = commandLine.Split().ToArray();
                string command = commandSplit[0];

                switch (command)
                {
                    case "Loot":
                        {
                            for (int i = 1; i < commandSplit.Length; i++)
                            {
                                if (!initialLootChest.Contains(commandSplit[i]))
                                {
                                    initialLootChest.Insert(0, commandSplit[i]);
                                }
                            }
                            break;
                        }
                    case "Drop":
                        {
                            int indexToRemove = int.Parse(commandSplit[1]);
                            string tempValue = string.Empty;

                            if ((indexToRemove >= 0) && (indexToRemove < initialLootChest.Count - 1)) //max value test ?
                            {
                                tempValue = initialLootChest[indexToRemove];
                                initialLootChest.RemoveAt(indexToRemove);
                                initialLootChest.Add(tempValue);
                            }
                            break;
                        }
                    case "Steal":
                        {
                            int count = int.Parse(commandSplit[1]);
                            int initialIndex = initialLootChest.Count - count;
                            int range = initialIndex + count;

                            if (initialIndex < 0)
                            {
                                initialIndex = 0;
                            }

                            if (count > initialLootChest.Count)
                            {
                                count = initialLootChest.Count;
                            }

                            if (range > initialLootChest.Count)
                            {
                                range = initialLootChest.Count;
                            }

                            for (int i = initialIndex; i < range; i++)
                            {
                                stealItems.Add(initialLootChest[i]);
                            }

                            initialLootChest.RemoveRange(initialIndex, count);
                            break;
                        }
                    default:
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", stealItems));
            int totalItemLength = 0;

            foreach (var item in initialLootChest)
            {
                totalItemLength += item.Length;
            }
            double averageGain = (double)totalItemLength / (double)initialLootChest.Count;

            if (initialLootChest.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {averageGain:0.00} pirate credits.");

            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }

        }
    }
}
