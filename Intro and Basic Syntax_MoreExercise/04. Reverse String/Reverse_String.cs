using System;

namespace _04._Reverse_String
{
    class Reverse_String
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reverse = input.ToCharArray();
            Array.Reverse(reverse);

            string output = new string(reverse);

            Console.WriteLine(output);
        }
    }
}
