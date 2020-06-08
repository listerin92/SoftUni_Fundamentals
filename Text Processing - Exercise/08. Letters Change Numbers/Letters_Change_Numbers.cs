using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Letters_Change_Numbers
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string newWord = string.Empty;
            double totalResult = 0.0;

            foreach (var word in words)
            {
                double localResult = 0.0;
                char firstLetter = word.First();
                char lastLetter = word.Last();
                newWord = word.Remove(0, 1);
                newWord = newWord.Remove(newWord.Length - 1);

                double number = double.Parse(newWord);

                int firstLetterPossition = char.Parse(firstLetter.ToString().ToLower()) - 96;
                int lastLetterPossition = char.Parse(lastLetter.ToString().ToLower()) - 96;

                if (char.IsUpper(firstLetter))
                {
                    localResult += number / firstLetterPossition;
                }
                else
                {
                    localResult += number * firstLetterPossition;
                }
                if (char.IsUpper(lastLetter))
                {
                    localResult -= lastLetterPossition;
                }
                else
                {
                    localResult += lastLetterPossition;
                }
                totalResult += localResult;
            }
            Console.WriteLine($"{totalResult:0.00}");
        }
    }
}

