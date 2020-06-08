using System;

namespace _07._Concat_Names
{
    class Concat_Names
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var delimiter = Console.ReadLine();
            Console.WriteLine($"{firstName}{delimiter}{lastName}");
        }
    }
}
