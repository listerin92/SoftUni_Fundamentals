﻿using System;
using System.Linq;

namespace _05._Word_Filter
{
    class Word_Filter
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
