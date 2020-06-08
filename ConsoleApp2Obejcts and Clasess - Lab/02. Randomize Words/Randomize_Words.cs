using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Randomize_Words
{
    class Randomize_Words
    {
        static void Main(string[] args)
        {
            List<string> inputString = Console.ReadLine().
                Split().
                ToList();

            string tempHolder = string.Empty;

            for (int i = 0; i < inputString.Count; i++)
            {
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, inputString.Count - 1);
                tempHolder = inputString[randomIndex];
                inputString[randomIndex] = inputString[i];
                inputString[i] = tempHolder;
            }

            Console.WriteLine(string.Join(Environment.NewLine, inputString));
        }
    }
}
