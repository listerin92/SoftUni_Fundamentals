using System;
using System.Text;

namespace _03._Characters_in_Range
{
    class Characters_in_Range
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string result = CharSequence(firstChar, secondChar);
            Console.WriteLine(result);
            
        }
        private static string CharSequence(char firstChar, char secondChar)
        {
            int startChar = Math.Min(firstChar, secondChar);
            int endChar = Math.Max(firstChar, secondChar);

            StringBuilder str = new StringBuilder();

            for (int i = startChar + 1; i < endChar; i++)
            {
                str.Append((char)i+" ");
            }
            return str.ToString();
        }

    }
}
