using System;

namespace _02._English_Name_of_the_Last_Digit
{


    class English_Name_of_the_Last_Digit
    {

        static void Main(string[] args)
        {
             int input = int.Parse(Console.ReadLine());
             Console.WriteLine(MyMethod(input));
        }

        static string MyMethod(int input)
        {
            string holder = input.ToString();
            char[] num = holder.ToCharArray();
            int val = (int)Char.GetNumericValue(num[num.Length-1]);
            return val switch
            {
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                _ => "zero",
            };
        }
   }
}
