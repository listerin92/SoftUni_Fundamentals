using System;
using System.Text;

namespace _03._Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine().ToLower();
            string secondString = Console.ReadLine();
            int result = 0;
            do
            {
                result = secondString.IndexOf(firstString);
                if (result == -1)
                {
                    break;
                }
                secondString = secondString.Remove(result, firstString.Length);
            }
            while (true);


            Console.WriteLine(secondString);
        }

    }
}
