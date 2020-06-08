using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Refactor_Volume_of_Pyramid
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            double baseLength = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double baseWidth = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double pyramidHeight = double.Parse(Console.ReadLine());

            double volume = (baseLength * baseWidth * pyramidHeight) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}
