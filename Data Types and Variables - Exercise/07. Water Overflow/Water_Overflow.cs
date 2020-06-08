using System;

namespace _07._Water_Overflow
{
    class Water_Overflow
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(Console.ReadLine());
            ushort[] quantites = new ushort[n];
            int result = 0;

            for (ushort i = 0; i < quantites.Length; i++)
            {
                quantites[i] = ushort.Parse(Console.ReadLine());

                if (result + quantites[i] > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }

                else

                {
                    result += quantites[i];
                }
            }
            Console.WriteLine(result);

        }
    }
}
