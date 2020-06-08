using System;
using System.Collections;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Palindrome_Integers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                string reverse = ReverseString(input);
                string result = CheckPalindrom(input, reverse);
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
        private static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
           
        }
        private static string CheckPalindrom(string input, string reverse)
        {
            if (input.CompareTo(reverse) == 0)
            {
                return "true";
            }
            else return "false";
        }
    }
}
