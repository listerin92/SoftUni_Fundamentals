using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            SortedDictionary<string, Dictionary<decimal, decimal>> dataDemons = new SortedDictionary<string, Dictionary<decimal, decimal>>();
            foreach (var demon in input)
            {
                decimal damage = Damage(demon);
                decimal health = Health(demon);

                damage = MultyDivide(demon, damage);

                Fill(dataDemons, demon, damage, health);

            }
            Print(dataDemons);
        }

        private static void Fill(SortedDictionary<string, Dictionary<decimal, decimal>> dataDemons, string demon, decimal damage, decimal health)
        {
            var inner = new Dictionary<decimal, decimal>();
            inner.Add(health, damage);
            dataDemons.Add(demon, inner);
        }

        private static void Print(SortedDictionary<string, Dictionary<decimal, decimal>> dataDemons)
        {
            foreach (var item in dataDemons)
            {
                Console.Write("{0} - ", item.Key);
                foreach (var i in item.Value)
                {
                    Console.WriteLine("{0} health, {1:f2} damage", i.Key, i.Value);
                }
            }
        }

        private static decimal MultyDivide(string demon, decimal damage)
        {
            string patternSign = @"[*\|/]";
            var regsigns = new Regex(patternSign);
            MatchCollection matchSigns = regsigns.Matches(demon);
            if (matchSigns.Count > 0)
            {
                foreach (Match sign in matchSigns)
                {
                    string c = sign.ToString();
                    if (c == "/")
                    {
                        damage /= 2;
                    }
                    else if (c == "*")
                    {
                        damage *= 2;
                    }
                }
            }

            return damage;
        }

        private static decimal Health(string demon)
        {
            decimal health = 0;

            string patternChars = @"[A-Za-z]*[^\d\.\+\-\*\/\s]+";
            var regChars = new Regex(patternChars);
            MatchCollection matchChar = regChars.Matches(demon);
            if (matchChar.Count > 0)
            {
                foreach (Match letters in matchChar)
                {
                    string temp = letters.ToString();
                    foreach (var ch in temp)
                    {
                        health += (int)ch;
                    }
                }
            }

            return health;
        }

        private static decimal Damage(string demon)
        {
            decimal damage = 0;
            //match only digits like -5.2, 5 +2.6 .....
            string patternDigits = @"[+-]?[\d+\.]*[\d]+";
            var regDigits = new Regex(patternDigits);
            MatchCollection matchDigits = regDigits.Matches(demon);
            if (matchDigits.Count > 0)
            {
                foreach (Match digit in matchDigits)
                {
                    string temp = digit.ToString();
                    decimal num = decimal.Parse(temp);
                    damage += num;
                }
            }

            return damage;
        }
    }
}