using System;
using System.Text;

namespace _06._Middle_Characters
{
    class Middle_Characters
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            Console.WriteLine(MiddleString(inputStr));
        }
        private static string MiddleString(string inputStr)
        {
            StringBuilder output = new StringBuilder();
            int first = (inputStr.Length / 2)-1;
            int second = (inputStr.Length / 2);
            if (inputStr.Length % 2 != 0)
            {
                output.Append(inputStr[second]);
                return output.ToString();
            }
            else
            {
                output.Append(inputStr[first]);
                output.Append(inputStr[second]);
                return output.ToString();
            }

        }

    }
}
