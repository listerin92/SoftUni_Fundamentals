using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _07._Order_by_Age
{
    class Order_by_Age
    {
        static void Main(string[] args)
        {
            string end = string.Empty;
            List<People> people = new List<People>();
            while ((end = Console.ReadLine()) != "End")
            {

                List<string> tokens = end.Split(" ").ToList();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);
                People onePerson = new People(name, id, age);
                people.Add(onePerson);

            }
            people = people.OrderBy(o => o.Age).ToList();

            foreach (var ppl in people)
            {
                Console.WriteLine($"{ppl.Name} with ID: {ppl.ID} is {ppl.Age} years old.");
            }

        }
    }
    class People
    {
        public People(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }

}
