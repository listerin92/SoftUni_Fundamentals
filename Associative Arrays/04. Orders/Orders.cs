using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<double>> nameTotalPrice = new Dictionary<string, List<double>>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] tokens = input.Split(' ').ToArray();
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                int ammount = int.Parse(tokens[2]);

                if (!nameTotalPrice.ContainsKey(product))
                {
                    nameTotalPrice.Add(product, new List<double>() { 0, 0 });
                }
                nameTotalPrice[product][0] = price;
                nameTotalPrice[product][1] += ammount;
            }

            foreach (var item in nameTotalPrice)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):0.00}");
            }
        }
    }
}
