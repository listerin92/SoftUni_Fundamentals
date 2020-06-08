using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            int numberOfSnowball = int.Parse(Console.ReadLine());
            int[] data = new int[numberOfSnowball * 3];

            for (int i = 0; i < 3 * numberOfSnowball; i++)
            {
                data[i] = int.Parse(Console.ReadLine());
            }

            BigInteger snowballValue = -1, tempsnowballValue;
            int snowballSnow=0, snowballTime=0, snowballQuality=0;

            for (int i = 0; i < data.Length-2; i+=3)
            {

                tempsnowballValue = BigInteger.Pow((data[i] / data[i + 1]), data[i + 2]);

                if (tempsnowballValue>=snowballValue)
                {
                    snowballValue = tempsnowballValue;
                    snowballSnow = data[i];
                    snowballTime = data[i + 1];
                    snowballQuality = data[i + 2];
                }

            }

            Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");

        }
    }
}
