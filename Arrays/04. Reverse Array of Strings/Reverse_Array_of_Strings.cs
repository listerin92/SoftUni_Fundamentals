using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Reverse_Array_of_Strings
    {
        static void Main(string[] args)
        {
            string[] chars = Console.ReadLine().Split(" ").ToArray();
            Array.Reverse(chars);
            foreach (var item in chars)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
