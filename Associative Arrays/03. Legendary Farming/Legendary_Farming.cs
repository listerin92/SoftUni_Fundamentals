using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Legendary_Farming
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            keyMaterials.Add("shards", 0);
            keyMaterials.Add("motes", 0);
            keyMaterials.Add("fragments", 0);

            bool legendaryItemReady = false;

            do
            {
                string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
                for (int i = 0; i < input.Length; i += 2)
                {
                    int ammount = int.Parse(input[i]);
                    string item = input[i + 1];

                    CheckInputAndFillDict(keyMaterials, junkMaterials, ammount, item);

                    if (CheckKeyMaterials(keyMaterials, "shards", "Shadowmourne"))
                    {
                        legendaryItemReady = true;
                        break;
                    }
                    if (CheckKeyMaterials(keyMaterials, "motes", "Dragonwrath"))
                    {
                        legendaryItemReady = true;
                        break;
                    }
                    if (CheckKeyMaterials(keyMaterials, "fragments", "Valanyr"))
                    {
                        legendaryItemReady = true;
                        break;
                    }
                }
            } 
            while (legendaryItemReady != true);

            Print(keyMaterials, junkMaterials);
        }
        private static bool CheckKeyMaterials(Dictionary<string, int> keyMaterials, string keyMat, string item)
        {
            if (keyMaterials.TryGetValue(keyMat, out int keyMatCollected) && keyMatCollected >= 250)
            {
                Console.WriteLine($"{item} obtained!");
                keyMaterials[keyMat] -= 250;
                return true;
            }
            return false;
        }
        private static void Print(Dictionary<string, int> keyMaterials, Dictionary<string, int> junkMaterials)
        {
            var sortedKeyMaterials = keyMaterials.OrderBy(o => o.Key).OrderByDescending(o => o.Value);
            foreach (var item in sortedKeyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            var sortedJunkMaterials = junkMaterials.OrderBy(o => o.Key);
            foreach (var item in sortedJunkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static void CheckInputAndFillDict(Dictionary<string, int> keyMaterials, Dictionary<string, int> junkMaterials, int ammount, string item)
        {
            if (keyMaterials.ContainsKey(item))
            {
                keyMaterials[item] += ammount;
            }

            else
            {
                if (!junkMaterials.ContainsKey(item))
                {
                    junkMaterials.Add(item, 0);
                }
                junkMaterials[item] += ammount;
            }
        }
    }
}
