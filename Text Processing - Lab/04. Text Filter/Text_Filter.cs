using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Text_Filter
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();
            int result = 0;
            string res = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                string subs = new string('*', words[i].Length);
                if (result == -1)
                {
                    break;
                }
                text = text.Replace(words[i], subs);
            }
            Console.WriteLine(text);
        }
    }
}
