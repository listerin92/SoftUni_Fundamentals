using System;
using System.Text;

namespace _07._String_Explosion
{
    class String_Explosion
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int strength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                    continue;
                }

                if (strength > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    strength--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
