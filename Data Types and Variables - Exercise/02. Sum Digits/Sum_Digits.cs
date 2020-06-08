using System;

namespace _02._Sum_Digits
{
    class Sum_Digits
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] intArray = intToArray(input);
            int result = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                result += intArray[i];
            }
            Console.WriteLine(result);
        }
        public static int[] intToArray(int num)
        {
            String holder = num.ToString();
            int[] numbers = new int[holder.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(holder[i].ToString());
            }
            return numbers;
        }

    }
}
