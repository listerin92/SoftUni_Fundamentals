using System;

namespace _07._Repeat_String
{
    class Repeat_String
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(str, count);
            Console.WriteLine(result);
        }
        private static string RepeatString(string str, int count)
        {
            string result = String.Empty;
            for (int i = 0; i < count; i++)
            {
                result += str;
            }
            return result;
        }
    }
}
