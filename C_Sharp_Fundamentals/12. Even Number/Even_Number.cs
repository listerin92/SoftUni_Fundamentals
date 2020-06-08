using System;

namespace _12._Even_Number
{
    class Even_Number
    {
        static void Main(string[] args)
        {
            var inputEven=0;
            do
            {
                 inputEven = int.Parse(Console.ReadLine());
                if (inputEven % 2 == 0) break;
                    Console.WriteLine("Please write an even number.");
            }while (inputEven % 2 != 0);
            Console.WriteLine("The number is: {0}", Math.Abs(inputEven));
        }
    }
}
