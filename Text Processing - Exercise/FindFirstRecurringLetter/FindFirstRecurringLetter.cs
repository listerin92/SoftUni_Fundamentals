using System;
using System.Collections.Generic;

namespace FindFirstRecurringLetter
{
    class FindFirstRecurringLetter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = FirstRecurring(input);
            Console.WriteLine(result);
        }

        static char FirstRecurring(string input)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (var ch in input)
            {
                if (counts.ContainsKey(ch))
                {
                    return ch;
                }

                counts[ch] = 1;
            }

            return '\0';

        }
    }
}
