using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Match_Phone_Number
    {
        static void Main(string[] args)
        {
            string regex = @"\+359([ -])2\1\d{3}\1\b\d{4}\b";
            string phones = Console.ReadLine();
            MatchCollection phoneMatches = Regex.Matches(phones,regex);
            var matchedPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
