using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Star_Enigma
    {
        static void Main(string[] args)
        {
            byte noOfLines = byte.Parse(Console.ReadLine());
            List<Planet> planets = new List<Planet>();
            string splitter = @"@(?<planet>[A-Za-z]+)([^@\-!:>]*):(?<population>[0-9]+)([^@\-!:>]*)!(?<attacType>[AD])!([^@\-!:>]*)->(?<solderCount>[0-9]+)";
            for (int i = 0; i < noOfLines; i++)
            {

                string encryptedMessage = Console.ReadLine();
                int key = CountCryptoKey(encryptedMessage);
                string decryptedMessage = DecryptMessage(encryptedMessage, key);

                if (isSucess(decryptedMessage, splitter) != false) // not Fill if empty
                {
                    planets.Add(FillPlanetInfo(decryptedMessage, splitter));
                }
            }
            Print(planets);
        }

        private static bool isSucess(string decryptedMessage, string splitter)
        {
            return Regex.IsMatch(decryptedMessage, splitter);
        }

        private static void Print(List<Planet> planets)
        {
            var attackedPlanetsCount = planets.Where(w => w.AttackType == "A").Count();
            Console.WriteLine($"Attacked planets: {attackedPlanetsCount}");
            foreach (var item in planets.OrderBy(o => o.PlanetName).Where(w => w.AttackType == "A"))
            {
                Console.WriteLine($"-> {item.PlanetName}");
            }

            var destroyedPlanetsCount = planets.Where(w => w.AttackType == "D").Count();
            Console.WriteLine($"Destroyed planets: {destroyedPlanetsCount}");
            foreach (var item in planets.OrderBy(o => o.PlanetName).Where(w => w.AttackType == "D"))
            {
                Console.WriteLine($"-> {item.PlanetName}");
            }
        }

        private static Planet FillPlanetInfo(string sb, string split)
        {

            var splittedMessage = Regex.Match(sb, split);

            string pl = splittedMessage.Groups["planet"].Value;
            int pp = int.Parse(splittedMessage.Groups["population"].Value);
            string atype = splittedMessage.Groups["attacType"].Value;
            int sc = int.Parse(splittedMessage.Groups["solderCount"].Value);
            return new Planet(pl, pp, atype, sc);
        }

        private static string DecryptMessage(string line, int key)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var ch in line)
            {
                sb.Append((char)(ch - key)); //decrypt with special key which is number of regex matches
            }
            return sb.ToString();
        }
        static int CountCryptoKey(string message)
        {
            string pattern = @"[STARstar]";

            MatchCollection lettersKey = Regex.Matches(message, pattern);

            return lettersKey.Count();
        }
    }
    class Planet
    {
        public Planet(string planetname, int planetpopulation, string attacktype, int soldercount)
        {
            PlanetName = planetname;
            PlanetPopulation = planetpopulation;
            AttackType = attacktype;
            SolderCount = soldercount;
        }
        public string PlanetName { get; set; }
        public int PlanetPopulation { get; set; }
        public string AttackType { get; set; }
        public int SolderCount { get; set; }

    }
}
