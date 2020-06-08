using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Students_2_0
{
    class Students_2_0
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
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string town = tokens[3];

                if (isStudentExists(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.Age = age;
                    student.Hometown = town;
                }
                else
                {
                    Student student = new Student();
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = town;
                    students.Add(student);
                }
            }

            string filteredCity = Console.ReadLine();

            List<Student> filterdStudents = students.Where(s => s.Hometown == filteredCity).ToList();

            foreach (Student student in filterdStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
        static bool isStudentExists(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
    }
}
