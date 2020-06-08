using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Bomb_Numbers
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToList();

            List<int> specialNumAndPower = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToList();

            int specialNumber = specialNumAndPower[0];
            int power = specialNumAndPower[1];


            List<int> index = FindIndexes(sequence, specialNumber);

            Bomb(sequence, power, index, specialNumber);

            PrintRemainingItemsSum(sequence);
        }
        private static void PrintRemainingItemsSum(List<int> sequence)
        {
            /*int sum = 0;
             
            foreach (var item in sequence)
            {
                sum += item;
            }*/
            Console.WriteLine(sequence.Sum());
        }
        private static void Bomb(List<int> sequence, int power, List<int> index, int specialNumber)
        {
            foreach (var item in index)
            {
                //if specialBombNumber is not destroyed
                if (specialNumber == sequence[item])
                {
                    for (int i = 0; i <= power; i++)
                    {
                        if (item - i >= 0)
                        {
                            sequence[item - i] = 0;
                        }
                        if (item + i < sequence.Count)
                        {
                            sequence[item + i] = 0;
                        }
                    }
                }
            }
        }

        // find all indexes in List for every specialNumber
        private static List<int> FindIndexes(List<int> sequence, int specialNumber)
        {
            List<int> index = sequence.Select((x, i) => new { x, i })
                                        .Where(x => x.x == specialNumber)
                                        .Select(x => x.i)
                                        .ToList();

            return index;
        }
    }
}
