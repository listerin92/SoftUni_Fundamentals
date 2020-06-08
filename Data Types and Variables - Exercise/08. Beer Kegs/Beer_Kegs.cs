using System;

namespace _08._Beer_Kegs
{
    class Beer_Kegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] kegs = new string[n * 3];
            for (int i = 0; i < 3*n; i++)
            {
                kegs[i] = Console.ReadLine();
            }

            double radius,volume=0.0, volumetemp = 0.0;
            int height;
            string winnerModel="";

            for (int i = 0; i < kegs.Length-2; i+=3)
            {
                radius = Convert.ToDouble(kegs[i + 1]);
                height = Convert.ToInt32(kegs[i + 2]);
                volumetemp = Math.PI * radius * radius * height;
                if (volumetemp > volume)
                {
                    volume = volumetemp;
                    winnerModel = kegs[i];
                }
            }
            Console.WriteLine(winnerModel);
        }
    }
}
