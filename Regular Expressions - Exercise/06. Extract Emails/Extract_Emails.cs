using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Extract_Emails
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(?<=\s)[A-Za-z][a-zA-Z-_.]*\w*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,})";
            MatchCollection matches = Regex.Matches(input, regex);
            foreach (var match in matches)
            {
                Console.WriteLine(match);

            }

        }
    }
}
