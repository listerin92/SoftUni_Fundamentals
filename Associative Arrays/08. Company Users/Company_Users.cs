using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Company_Users
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> companyNameID = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" -> ").ToArray();
                string company = tokens[0];
                string id = tokens[1];

                if (!companyNameID.ContainsKey(company))
                {
                    companyNameID.Add(company, new List<string>());
                }
                if (!companyNameID[company].Contains(id))
                {
                    companyNameID[company].Add(id);
                }

            }
            foreach (var companyName in companyNameID.OrderBy(o => o.Key))
            {
                Console.WriteLine($"{companyName.Key}");

                foreach (var id in companyName.Value)
                {
                    Console.WriteLine($"-- {id}");

                }
            }
        }
    }
}
