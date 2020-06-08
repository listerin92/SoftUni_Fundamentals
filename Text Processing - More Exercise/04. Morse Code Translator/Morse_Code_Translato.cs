using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Translator
{
    class Morse_Code_Translato
    {
        static void Main(string[] args)
        {
            string[] morseTranslate = new string[26]
               {".-", "-...","-.-.","-..",".","..-.", "--.", "....", "..",
                ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-",
                ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
               };

            string[] morse = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < morse.Length; i++)
            {
                for (int j = 0; j < morseTranslate.Length; j++)
                {
                    if (morse[i] == morseTranslate[j])
                    {
                        sb.Append((char)(j + 65));
                        break;
                    }
                    else if (morse[i] == "|")
                    {
                        sb.Append((char)(32));
                        break;
                    }
                }

            }
            Console.WriteLine(sb);

        }

    }
}

