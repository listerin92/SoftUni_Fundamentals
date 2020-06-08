using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class SoftUni_Bar_Income
    {
        static void Main(string[] args)
        {
            // name between % % 
            string regex = @"\%(?<customer>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+[.]*\d+?)\$";
            string lineCommand;
            List<Order> orders = new List<Order>();
            while ((lineCommand = Console.ReadLine()) != "end of shift")
            {
                var match = Regex.Match(lineCommand, regex);

                if (Regex.IsMatch(lineCommand, regex) == false) // skip if no match
                {
                    continue;
                }

                string customerName = match.Groups["customer"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                double price = double.Parse(match.Groups["price"].Value);

                Order order = new Order(customerName, product, count, price);

                orders.Add(order);
            }
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
            double income = orders.Sum(s => s.TotalPrice);
            Console.WriteLine($"Total income: {income:f2}");
            
        }
    }

    class Order
    {
        public Order(string name, string product, int count, double price)
        {
            Name = name;
            Product = product;
            Count = count;
            Price = price;
        }
        public string Name { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double TotalPrice
        {
            get
            {
                return Count * Price;
            }
        }

        public override string ToString()
        {
            string result = $"{Name}: {Product} - {TotalPrice:f2}";
            return result;
        }

    }
}
