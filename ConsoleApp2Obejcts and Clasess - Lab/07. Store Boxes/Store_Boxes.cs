using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Store_Boxes
    {
        public class Item
        {
            public string ItemName { get; set; }
            public double ItemPrice { get; set; }

        }
        public class Box
        {
            public Box()
            {
                Item = new Item();
            }

            public int SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public double PriceABox { get; set; }

        }

        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                BoxFill(boxes, command);
            }

            List<Box> SortedBoxes = boxes.OrderByDescending(o => o.PriceABox).ToList();

            Print(SortedBoxes);
        }

        private static void BoxFill(List<Box> boxes, string end)
        {
            string[] tokens = end.Split();

            Box box = new Box();

            box.SerialNumber = int.Parse(tokens[0]);
            box.Item.ItemName = tokens[1];
            box.Item.ItemPrice = double.Parse(tokens[3]);
            box.ItemQuantity = int.Parse(tokens[2]);
            box.PriceABox = box.Item.ItemPrice * box.ItemQuantity;
            boxes.Add(box);
        }

        private static void Print(List<Box> boxes)
        {
            foreach (var box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.ItemName} - ${box.Item.ItemPrice:0.00}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceABox:0.00}");

            }
        }
    }
}
