using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Reverse_Strings
{
    class Reverse_Strings
    {
        static void Main(string[] args)
        {
            List<string> reverseCollection = new List<string>();
            List<string> originalCollection = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                originalCollection.Add(input);
                string reverse = string.Empty;
                if (input == "end")
                {
                    break;
                }

                for (int j = input.Length - 1; j >= 0; j--)
                {
                    reverse += input[j];
                }
                reverseCollection.Add(reverse);
            }
            for (int i = 0; i < originalCollection.Count-1; i++)
            {
                Console.WriteLine($"{originalCollection[i]} = {reverseCollection[i]}");
            }
        }
    }
}
