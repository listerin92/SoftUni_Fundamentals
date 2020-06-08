using System;
using System.Text;

namespace _07._NxN_Matrix
{
    class NxN_Matrix
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.Write(PrintNxN(input));
        }
        private static string PrintNxN(int input)
        {
            StringBuilder strOut = new StringBuilder();

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    strOut.Append(input + " ");
                }
                strOut.Append("\n");
            }
            return strOut.ToString();
        }
    }
}
