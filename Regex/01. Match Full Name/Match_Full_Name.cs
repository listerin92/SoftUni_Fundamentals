using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Match_Full_Name
    {

        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";
            MatchCollection matchNames = Regex.Matches(names, pattern);

            foreach (Match name in matchNames)
            {
                Console.Write(name.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
