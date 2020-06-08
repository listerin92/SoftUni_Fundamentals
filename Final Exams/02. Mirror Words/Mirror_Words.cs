using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Mirror_Words
    {
        static void Main(string[] args)
        {
            string regex = @"(#{1}(\b[a-zA-Z]{3,}\b)#{2}(\b[a-zA-Z]{3,}\b)#{1})|(@{1}(\b[a-zA-Z]{3,}\b)@{2}(\b[a-zA-Z]{3,}\b)@{1})";
            string input = Console.ReadLine();

            MatchCollection match = Regex.Matches(input, regex);
            List<string> allWords = new List<string>();
            for (int i = 0; i < match.Count; i++)
            {
                for (int j = 2; j <= 6; j++)
                {
                    if (match[i].Groups[j].Value != "")
                    {
                        if (!match[i].Groups[j].Value.Contains("#") && !match[i].Groups[j].Value.Contains("@"))
                        {
                            allWords.Add(match[i].Groups[j].Value);
                        }
                    }
                }
            }
            List<string> matchedWords = new List<string>();
            for (int i = 0; i < allWords.Count - 1; i++)
            {
                string reverse = ReverseString(allWords[i + 1]);
                if (allWords[i] == reverse)
                {
                    matchedWords.Add(allWords[i]);
                    matchedWords.Add(allWords[i + 1]);
                }
                i++;

            }

            Print(match, matchedWords);

        }

        private static void Print(MatchCollection match, List<string> matchedWords)
        {
            if (match.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{match.Count} word pairs found!");
            }

            if (matchedWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");

                for (int i = 0; i < matchedWords.Count - 1; i += 2)
                {
                    Console.Write($"{matchedWords[i]} <=> {matchedWords[i + 1]}");
                    if (i < matchedWords.Count - 2)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
