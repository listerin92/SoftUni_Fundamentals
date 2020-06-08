using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace _03._Word_Synonyms
{
    class Word_Synonyms
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<string>());
                }
                words[word].Add(synonym);
            }


            foreach (var word in words)
            {
                StringBuilder print = new StringBuilder();

                print.Append(word.Key);
                print.Append(" - ");
                for (int i = 0; i < word.Value.Count; i++)
                {
                    print.Append(word.Value[i]);

                    if (i != word.Value.Count - 1)
                    {
                        print.Append(", ");
                    }
                }
                Console.WriteLine(print);
            }
        }
    }
}
