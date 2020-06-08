using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Students
    {
        
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> studentList = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                Student student = new Student(tokens[0], tokens[1], double.Parse(tokens[2]));
                studentList.Add(student);
            }
            studentList = studentList.OrderByDescending(o => o.Grade).ToList();
            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:0.00}");
            }
        }
    }

    class Student
    {
        public Student(string firstname, string lastname, double grade)
        {
            FirstName = firstname;
            LastName = lastname;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
