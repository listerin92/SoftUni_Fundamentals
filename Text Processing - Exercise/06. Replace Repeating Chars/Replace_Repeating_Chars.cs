using System;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Replace_Repeating_Chars
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    sb.Insert(0, input[i]);
                }
            }
            sb.Insert(0, input[input.Length - 1]);
            string result = ReverseString(sb.ToString());

            Console.WriteLine(result);
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
