using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Kamino_Factory
    {
        static void Main(string[] args)
        {
            int lengthOfSequences = int.Parse(Console.ReadLine());

            string input = null;
            int bestCount = 0, bestSum = 0, bestBeginIndex = 0;

            string bestSequence = "";
            int counter = 0, bestCounter = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                string sequence = input.Replace("!", "");
                string[] dnaParts = sequence.Split("0", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int count = 0, sum = 0;
                string bestSubSequence = "";
                counter++;

                foreach (var dnaPart in dnaParts)
                {
                    if (dnaPart.Length > count)
                    {
                        count = dnaPart.Length;
                        bestSubSequence = dnaPart;
                    }
                    sum += dnaPart.Length;
                }

                int beginIndex = sequence.IndexOf(bestSubSequence);

                if (count > bestCount ||
                    (count == bestCount && beginIndex < bestBeginIndex) ||
                    (count == bestCount && beginIndex < bestBeginIndex) && sum > bestSum ||
                    counter == 1)
                {
                    bestCount = count;
                    bestSequence = sequence;
                    bestBeginIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;
                }
            }

            char[] arrRes = bestSequence.ToCharArray();
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", arrRes));
        }
    }
}
