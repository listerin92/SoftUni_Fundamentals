using System;

namespace _02._Ascii_Sumator
{
    class Ascii_Sumator
    {
        static void Main(string[] args)
        {
            int charOne = char.Parse(Console.ReadLine());
            int charTwo = char.Parse(Console.ReadLine());
            string randString = Console.ReadLine();
            int start = Math.Min(charOne, charTwo);
            int end = Math.Max(charOne, charTwo);

            int sum = 0;
            for (int i = 0; i < randString.Length; i++)
            {
                int currentChar = randString[i];
                if (currentChar > start && currentChar < end)
                {
                    sum += currentChar;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
