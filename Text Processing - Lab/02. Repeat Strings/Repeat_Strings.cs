using System;
using System.Linq;
using System.Text;

namespace _02._Repeat_Strings
{
    class Repeat_Strings
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            StringBuilder result = new StringBuilder();
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }

            }
            Console.WriteLine(result);

        }
    }
}
