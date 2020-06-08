using System;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    class Valid_Usernames
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ").ToArray();
            bool flag = false;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if ((currentWord.Length >= 3) && (currentWord.Length <= 16))
                {
                    for (int j = 0; j < currentWord.Length; j++)
                    {
                        if (char.IsLetterOrDigit(currentWord[j])
                            || (currentWord[j] == '-')
                            || (currentWord[j] == '_'))
                        {
                            flag = true;
                        }
                        else { flag = false; break; }
                    }
                    if (flag)
                    {
                        Console.WriteLine(currentWord);
                    }
                }
            }
        }
    }
}
