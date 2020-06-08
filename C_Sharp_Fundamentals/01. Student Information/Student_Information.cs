using System;

namespace _01._Student_Information
{
    class Student_Information
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine()); 
            float grade = float.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:0.00}", name, age, grade);
        }
    }
}
