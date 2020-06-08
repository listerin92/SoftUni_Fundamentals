using System;

namespace _10._Poke_Mon
{
    class Poke_Mon
    {
        static void Main()
        {
            uint N = uint.Parse(Console.ReadLine());//poke power
            uint M = uint.Parse(Console.ReadLine());// distance
            ushort Y = ushort.Parse(Console.ReadLine());//exhaustionFactor
            double fifthyPercent = (double)N * 0.50;
            uint pokes = 0;
            while (N >= M)
            {
                pokes++;
                N -= M;
                if (fifthyPercent == N && Y != 0)
                {
                    N /= Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(pokes);
        }
    }
}
