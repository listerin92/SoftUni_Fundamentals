using System;

namespace _05._Messages
{
    class Messages
    {
        static void Main(string[] args)
        {
            int offset = 0;
            ushort letterLenght  = byte.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < letterLenght; i++)
            {
                ushort letter = ushort.Parse(Console.ReadLine());
                var letterStr = letter.ToString().ToCharArray();
                int NumberOfDigits = letterStr.Length;
                int MainDigit = (int)Char.GetNumericValue(letterStr[0]);
                offset = ((MainDigit - 2) * 3);

                if (MainDigit == 8 || MainDigit == 9)
                {
                    offset = ((MainDigit - 2) * 3) + 1;
                }

                int letterIndex = offset + NumberOfDigits - 1;
                int letterCode = letterIndex + 97;
                char letterFinal = (char)letterCode;

                if (letter == 0) // when letter is space
                {
                    letterFinal = (char)(MainDigit + 32);
                }

                message += letterFinal;

            }
            Console.WriteLine(message);
        }
    }
}
