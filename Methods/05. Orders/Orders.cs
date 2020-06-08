using System;


namespace _05._Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            string products = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            PriceCalculatinon(products, amount);

        }

        private static void PriceCalculatinon(string products, int amount)
        {

            switch (products)
            {
                case "water":
                    Console.WriteLine("{0:0.00}", amount * 1.00d);
                    break;
                case "coffee":
                    Console.WriteLine("{0:0.00}", amount * 1.50d);
                    break;
                case "coke":
                    Console.WriteLine("{0:0.00}", amount * 1.40d);
                    break;
                case "snacks":
                    Console.WriteLine("{0:0.00}", amount * 2.00d);
                    break;
                default:
                    break;
            }
        }


    }
}

