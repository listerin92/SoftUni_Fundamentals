using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Digits__Letters_and_Other
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder allOtherChars = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Append(input[i]);
                }
                else  if (char.IsLetter(input[i]))
                {
                    letters.Append(input[i]);
                }
                else
                {
                    allOtherChars.Append(input[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(allOtherChars);
        }
    }
}
