using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Character_Multiplier
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();


            string wordOne = words[0];
            string wordTwo = words[1];
            int result = 0;

            if (wordOne.Length < wordTwo.Length)
            {
                result = Calculate(wordOne, wordTwo);
            }
            else
            {
                result = Calculate(wordTwo, wordOne);
            }
            
            Console.WriteLine(result);
        }

        private static int Calculate(string shorter, string longer)
        {
            int result = 0;

            for (int i = 0; i < shorter.Length; i++)
            {
                result += shorter[i] * longer[i];
            }
            for (int i = shorter.Length; i < longer.Length; i++)
            {
                result += 1 * longer[i];
            }

            return result;
        }
    }
}
