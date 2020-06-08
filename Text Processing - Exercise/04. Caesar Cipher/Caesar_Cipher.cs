using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Caesar_Cipher
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            StringBuilder outStr = new StringBuilder();
            for (int i = 0; i < inputString.Length; i++)
            {
                outStr.Append((char)(inputString[i] + 3));
            }
            Console.WriteLine(outStr);
        }
    }
}
