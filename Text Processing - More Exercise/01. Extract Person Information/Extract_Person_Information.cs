using System;
using System.Collections.Generic;

namespace _01._Extract_Person_Information
{
    class Extract_Person_Information
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            List<string> sentence = new List<string>();
            for (int i = 0; i < nLines; i++)
            {
                sentence.Add(Console.ReadLine());
            }

            for (int i = 0; i < sentence.Count; i++)
            {
                int startName = sentence[i].IndexOf('@') + 1;
                int endName = sentence[i].IndexOf('|');
                string name = sentence[i].Substring(startName, endName - startName);

                int startAge = sentence[i].IndexOf('#') + 1;
                int endAge = sentence[i].IndexOf('*');
                string age = sentence[i].Substring(startAge, endAge - startAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
            

        }
    }
}
