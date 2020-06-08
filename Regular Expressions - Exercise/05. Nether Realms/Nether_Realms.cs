using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Nether_Realms
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<Demon> demonsCollection = FillDemon(line);

            Print(demonsCollection);

        }

        private static void Print(List<Demon> demonsCollection)
        {
            foreach (var demon in demonsCollection.OrderBy(o => o.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
        private static List<Demon> FillDemon(string line)
        {
            string[] demonName = DemonName(line);
            List<Demon> demonsCollection = new List<Demon>();

            for (int i = 0; i < demonName.Length; i++)
            {
                int health = TotalHealth(demonName[i]);
                List<string> opp = MultiplyDivide(demonName[i]);
                decimal damage = Damage(demonName[i], opp);
                Demon demon = new Demon(demonName[i], health, damage);
                demonsCollection.Add(demon);
            }
            return demonsCollection;
        }
        static string[] DemonName(string line)
        {
            string[] demonName = line.Split(new char[] {',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            // read conditions !!!!! separated by commas and zero or more spaces
            return demonName;
        }
        static List<string> MultiplyDivide(string message)
        {
            string pattern = @"[*\|\/]";
            var multydivide = Regex.Matches(message, pattern).Where(w => !String.IsNullOrEmpty(w.Value));
            List<string> opp = new List<string>();

            foreach (var item in multydivide)
            {
                opp.Add(item.ToString());
            }
            return opp;
        }
        static decimal Damage(string message, List<string> opp)
        {
            string pattern = @"[+-]?[\d+\.]*[\d]+"; //floating point number regex match
            decimal damage = 0.0m;
            MatchCollection dammageMatch = Regex.Matches(message, pattern);
            foreach (var dmg in dammageMatch)
            {
                damage += decimal.Parse(dmg.ToString());
            }
            foreach (var item in opp)
            {
                if (item == "*")
                {
                    damage *= 2;
                }
                else if (item == "/")
                {
                    damage /= 2;
                }
            }
            return damage;
        }
        static int TotalHealth(string message)
        {
            string pattern = @"[A-Za-z]*[^\d\.\+\-\*\/\s]+";
            int health = 0;
            MatchCollection lettersKey = Regex.Matches(message, pattern);
            if (lettersKey.Count > 0)
            {
                foreach (Match letters in lettersKey)
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
    }
    class Demon
    {
        public Demon(string name, int health, decimal damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public decimal Damage { get; set; }
    }
}
