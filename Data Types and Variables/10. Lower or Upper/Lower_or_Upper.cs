using System;

namespace _10._Lower_or_Upper
{
    class Lower_or_Upper
    {
        static void Main(string[] args)
        {
            char a1 = char.Parse(Console.ReadLine());
            bool result = Char.IsUpper(a1);
            if (result)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
