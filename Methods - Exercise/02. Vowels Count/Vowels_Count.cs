using System;

namespace _02._Vowels_Count
{
    class Vowels_Count
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int result = CountVowels(word);
            Console.WriteLine(result);

        }

        private static int CountVowels(string word)
        {
            char[] wordArr = word.ToCharArray();
            int count = 0;
            for (int i = 0; i < wordArr.Length; i++)
            {
                if (wordArr[i] == 'a' ||
                    wordArr[i] == 'e' ||
                    wordArr[i] == 'i' ||
                    wordArr[i] == 'o' ||
                    wordArr[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }

        //a e i o u
    }
}
