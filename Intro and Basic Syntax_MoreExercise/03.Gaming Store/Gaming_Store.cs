using System;

namespace _03.Gaming_Store
{
    public static class Store
    {
       public static string[,] games = {{   "OutFall 4",
                                            "CS: OG",
                                            "Zplinter Zell",
                                            "Honored 2",
                                            "RoverWatch",
                                            "RoverWatch Origins Edition"},
                                           {"39.99",
                                            "15.99",
                                            "19.99",
                                            "59.99",
                                            "29.99",
                                            "39.99"}};
    }
    class Gaming_Store
    {
        static void Main(string[] args)
        {
            double costOfPurchase = 0.00;
            double RemainingBalance;
            bool outOfMoneey = false;



            double InitialBalance = double.Parse(Console.ReadLine()); //first line
            var gameTitle = Console.ReadLine(); //game title lines
            while (gameTitle != "Game Time")
            {
                    var result = CheckGameAndPrice(gameTitle);

                    if (result.Item1 ==100)//100 is not found, price is below because out of boudary;
                    {
                        Console.WriteLine("Not Found");
                        gameTitle = Console.ReadLine();
                        continue;
                    }

                    double price = double.Parse(Store.games[result.Item1 + 1, result.Item2]);

                   if (InitialBalance < price)
                    {
                        Console.WriteLine("Too Expensive");
                        gameTitle = Console.ReadLine();
                        continue;
                    }

                    costOfPurchase += price;
                    RemainingBalance = InitialBalance - costOfPurchase;
                    
                    Console.WriteLine($"Bought {gameTitle}");

                    if (RemainingBalance < 0)
                    {
                        Console.WriteLine("Out of money!");
                        outOfMoneey = true;
                        break;
                    }

                    gameTitle = Console.ReadLine();
            }


            if (outOfMoneey == false)
            {
                RemainingBalance = InitialBalance - costOfPurchase;
                Console.WriteLine($"Total spent: ${costOfPurchase:0.00}. Remaining: ${RemainingBalance:0.00}");
            }
            
        }

        private static (int, int) CheckGameAndPrice(string gameTitle)
        {
            for (int i = 0; i < Store.games.GetLength(0); i++)
            {
                for (int j = 0; j < Store.games.GetLength(1); j++)
                {
                    if (gameTitle.ToString() == Store.games[i,j])
                    {
                        
                        return (i, j);
                    }

                }
            }
            return (100, 100);//when not found 
        }
    }
}
