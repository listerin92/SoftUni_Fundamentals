using System;

namespace _11._Multiplication_Table_2._0
{
    class ProMultiplication_Table_2_0
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            if (times <= 10)
            {
                for (int i = times; i <= 10; i++)
                {
                    var product = theInteger * i;
                    Console.WriteLine($"{theInteger} X {i} = {product}");
                }
            }
            else
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
        }
    }
}
