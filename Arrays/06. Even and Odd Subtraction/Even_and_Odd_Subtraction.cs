﻿using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Even_and_Odd_Subtraction
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0, oddSum = 0;
               
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }
            int difference = evenSum - oddSum;
            Console.WriteLine(difference);
        }
    }
}
