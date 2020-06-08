using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Cards_Game
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerHand = Console.ReadLine()
                                             .Split()
                                             .Select(int.Parse)
                                             .ToList();

            List<int> secondPlayerHand = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToList();


            for (int i = 0; i < Math.Min(firstPlayerHand.Count, secondPlayerHand.Count); i++)
            {
                if (firstPlayerHand[i] == secondPlayerHand[i])
                {
                    firstPlayerHand.RemoveAt(i);
                    secondPlayerHand.RemoveAt(i);
                    i-=1;
                    continue;
                }
                if (firstPlayerHand[i] > secondPlayerHand[i])
                {
                    firstPlayerHand.Add(firstPlayerHand[i]);
                    firstPlayerHand.Add(secondPlayerHand[i]);
                    firstPlayerHand.RemoveAt(i);
                    secondPlayerHand.RemoveAt(i);
                    i -=1;
                }
                else if (secondPlayerHand[i] > firstPlayerHand[i])
                {
                    secondPlayerHand.Add(secondPlayerHand[i]);
                    secondPlayerHand.Add(firstPlayerHand[i]);
                    secondPlayerHand.RemoveAt(i);
                    firstPlayerHand.RemoveAt(i);
                    i -= 1;
                }
            }
            int firstPlayerSum = firstPlayerHand.Sum();
            int secondPlayerSum = secondPlayerHand.Sum();

            if (firstPlayerSum > secondPlayerSum)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerSum}");

            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerSum}");
            }
        }
    }
}
