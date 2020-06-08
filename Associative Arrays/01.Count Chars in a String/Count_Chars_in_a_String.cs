using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Chars_in_a_String
{
    class Count_Chars_in_a_String
    {
        static void Main(string[] args)
        {
            var chars = Console.ReadLine()
                .Where(f => f != ' ');

            CountChars(chars);
        }

        private static void CountChars(IEnumerable<char> chars)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (var character in chars)
            {
                if (!counts.ContainsKey(character))
                {
                    counts.Add(character, 0);
                }
                counts[character]++;
            }
            foreach (var character in counts)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }

    }

}
