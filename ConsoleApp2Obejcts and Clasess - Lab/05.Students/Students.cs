using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    class Students
    {
        public class Student
        { 
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }

        }

        static void Main(string[] args)
        {
            string lines = string.Empty;
            List<Student> students = new List<Student>();

            while ((lines = Console.ReadLine()) != "end")
            {
                string[] tokens = lines.Split();

                Student student = new Student();
                student.FirstName = tokens[0];
                student.LastName = tokens[1];
                student.Age = int.Parse(tokens[2]);
                student.Hometown = tokens[3];
                
                students.Add(student);
            }
            string filteredCity = Console.ReadLine();

            List<Student> filterdStudents = students.Where(s => s.Hometown == filteredCity).ToList();

            foreach (Student student in filterdStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
