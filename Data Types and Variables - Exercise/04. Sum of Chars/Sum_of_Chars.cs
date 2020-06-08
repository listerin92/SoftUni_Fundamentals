using System;

namespace _04._Sum_of_Chars
{
    class Sum_of_Chars
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            char[] arr = new char[numOfLines];
            for (int i = 0; i < numOfLines; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double test = Char.GetNumericValue(arr[1]);
            Console.WriteLine($"The sum equals: {sum}");
        }
            
    }
}
