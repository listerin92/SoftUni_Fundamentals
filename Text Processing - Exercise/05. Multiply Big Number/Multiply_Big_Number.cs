using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Multiply_Big_Number
    {
        static void Main()
        {
            string bigNumber = Console.ReadLine();
            byte multiplier = byte.Parse(Console.ReadLine());
            StringBuilder bigNstr = new StringBuilder();
            int carry = 0;

            for (int i = bigNumber.Length; i > 0; i--)
            {
                int digit = bigNumber[i - 1] - '0';
                int result = (digit * multiplier) + carry;
                int resDigit = result % 10;
                carry = result / 10;

                bigNstr.Insert(0, resDigit);
            }

            if (carry > 0)
            {
                bigNstr.Insert(0, carry);
            }

            string value = bigNstr.ToString().TrimStart('0');
            if (value.Length == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(value);
            }
        }
    }
}
