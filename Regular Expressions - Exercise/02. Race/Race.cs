using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Race
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ").ToArray();
            Dictionary<string, int> position = new Dictionary<string, int>();

            string lineCommand;
            while ((lineCommand = Console.ReadLine()) != "end of race")
            {
                CheckNameDistance(names, lineCommand, position);
            }

            Print(position);
        }

        private static void CheckNameDistance(string[] names, string lines, Dictionary<string, int> position)
        {
            string regexName = @"([A-Za-z])";
            string regexDistances = @"\d";
            var matchedLetters = Regex.Matches(lines, regexName);

            string name = string.Join("", from Match match in matchedLetters select match.Value);
            var matchedDistance = Regex.Matches(lines, regexDistances).ToArray();

            int distance = 0;

            if (names.Contains(name))
            {
                for (int i = 0; i < matchedDistance.Length; i++)
                {
                    distance += int.Parse(matchedDistance[i].Value);
                }

                if (!position.ContainsKey(name))
                {
                    position.Add(name, distance);
                }
                else
                {
                    position[name] += distance;
                }
            }
        }

        private static void Print(Dictionary<string, int> position)
        {
            int counter = 0;
            foreach (var item in position.OrderByDescending(o => o.Value).Take(3))
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"{counter}st place: {item.Key}");
                }
                if (counter == 2)
                {
                    Console.WriteLine($"{counter}nd place: {item.Key}");

                }
                if (counter == 3)
                {
                    Console.WriteLine($"{counter}rd place: {item.Key}");

                }
            }
        }
    }
}
