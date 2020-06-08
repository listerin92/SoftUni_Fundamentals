using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Courses
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(" : ").ToArray();
                string course = tokens[0];
                string name = tokens[1];
                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }
                courses[course].Add(name);
            }
            foreach (var course in courses.OrderByDescending(o => o.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var name in course.Value.OrderBy(o => o))
                {
                    Console.WriteLine($"-- {name}");

                }
            }
        }
    }
}
