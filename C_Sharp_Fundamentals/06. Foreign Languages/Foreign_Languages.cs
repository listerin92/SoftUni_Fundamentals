using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main()
        {
            var country = Console.ReadLine();
            if (Equals(country,"England") || Equals(country,"USA"))
            {
                Console.WriteLine("English");
            }
            else if(Equals(country, "Spain") || Equals(country, "Argentina") || Equals(country, "Mexico"))
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
