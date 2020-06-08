using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Furniture
    {
        static void Main(string[] args)
        {
            string regex = @">>(?<furniture>\w+)<<(?<price>\d+[.]\d+|\d+)!(?<quantity>\d+)";
            string input = string.Empty;
            double spend = 0.0, perFurnitureSpend = 0.0;
            List<string> furnitures = new List<string>();
            do
            {
                var matchedPurchases = Regex.Matches(input, regex);
                foreach (Match matches in matchedPurchases)
                {
                    furnitures.Add(matches.Groups["furniture"].Value);
                    double price = double.Parse(matches.Groups["price"].Value);
                    double quantity = double.Parse(matches.Groups["quantity"].Value);

                    perFurnitureSpend = price * quantity;

                }
                if (matchedPurchases.Count !=0)
                {
                    spend += perFurnitureSpend;

                }
            }
            while ((input = Console.ReadLine()) != "Purchase");

            Console.WriteLine("Bought furniture:");
            foreach (var furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {spend:f2}");
        }
    }
}
