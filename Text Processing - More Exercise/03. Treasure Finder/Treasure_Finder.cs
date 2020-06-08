using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    class Treasure_Finder
    {
        static void Main(string[] args)
        {
            int[] keySequence = Console.ReadLine()
                .Split(' ', StringSplitOptions
                .RemoveEmptyEntries)
                .Select(Int32.Parse).ToArray();
            string command = string.Empty;
            StringBuilder sb = new StringBuilder();

            while ((command = Console.ReadLine()) != "find")
            {
                sb.Clear();
                for (int i = 0; i < command.Length; i += keySequence.Length)
                {
                    int length = Math.Min((keySequence.Length + i), command.Length);
                    for (int j = i, k = 0; j < length; j++, k++)
                    {
                        char letter = (char)(command[j] - keySequence[k]);
                        sb.Append(letter);
                    }
                }
                Print(sb);
            }
        }

        private static void Print(StringBuilder sb)
        {
            string decryptedSentence = sb.ToString();
            int startType = decryptedSentence.IndexOf('&') + 1;
            int endType = decryptedSentence.IndexOf('&', startType);
            string type = decryptedSentence.Substring(startType, endType - startType);

            int startCoord = decryptedSentence.IndexOf('<') + 1;
            int endCoord = decryptedSentence.IndexOf('>');
            string coordinates = decryptedSentence.Substring(startCoord, endCoord - startCoord);

            Console.WriteLine($"Found {type} at {coordinates}");
        }
    }
}
