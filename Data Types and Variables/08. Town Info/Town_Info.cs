using System;

namespace _08._Town_Info
{
    class Town_Info
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var polulation = Console.ReadLine();
            var area = Console.ReadLine();
            Console.WriteLine($"Town {town} has population of {polulation} and area {area} square km.");
        }
    }
}
