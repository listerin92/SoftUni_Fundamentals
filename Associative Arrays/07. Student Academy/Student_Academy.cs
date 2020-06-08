using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Student_Academy
    {
        static void Main(string[] args)
        {
            int pairOfRows = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> nameGrade = new Dictionary<string, List<double>>();

            for (int i = 0; i < pairOfRows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!nameGrade.ContainsKey(name))
                {
                    nameGrade.Add(name, new List<double>());
                }
                nameGrade[name].Add(grade);
            }

            foreach (var eachStudent in nameGrade.OrderByDescending(x => x.Value.Average()))
            {
                if (eachStudent.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{eachStudent.Key} -> {eachStudent.Value.Average():0.00}");
                }
            }
            
        }
    }
}
