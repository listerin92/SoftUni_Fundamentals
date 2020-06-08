using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._ForceBook
{
    class ForceBook
    {
        static void Main(string[] args)
        {
            string[] delimters = new string[] { " | ", " -> " };
            string forceSide = string.Empty;
            string forceUser = string.Empty;
            Dictionary<string, string> users = new Dictionary<string, string>();
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                string[] tokens = input.Split(delimters, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input.Contains("|")) //add to side
                {
                    forceSide = tokens[0];
                    forceUser = tokens[1];

                    if (!users.ContainsKey(forceUser))
                    {
                        users.Add(forceUser, forceSide);


                        if (!sides.ContainsKey(forceSide))
                        {
                            sides.Add(forceSide, new List<string>());
                        }

                        if (!sides[forceSide].Contains(forceUser))
                        {
                            sides[forceSide].Add(forceUser);
                        }
                    }

                }
                else //change side
                {
                    forceSide = tokens[1];
                    forceUser = tokens[0];
                    if (!users.ContainsKey(forceUser))
                    {
                        users.Add(forceUser, forceSide);

                        if (!sides.ContainsKey(forceSide))
                        {
                            sides.Add(forceSide, new List<string>());
                        }
                        sides[forceSide].Add(forceUser);
                    }
                    else
                    {
                        string oldForceSide = users[forceUser];
                        users[forceUser] = forceSide;

                        sides[oldForceSide].Remove(forceUser); //remove from oldForceSide

                        if (!sides.ContainsKey(forceSide))
                        {
                            sides.Add(forceSide, new List<string>());
                        }

                        sides[forceSide].Add(forceUser); //Add to new forceSide
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");


                }
            }

            foreach (var side in sides.Where(s => s.Value.Count > 0).OrderByDescending(o => o.Value.Count).ThenBy(o => o.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var user in side.Value.OrderBy(o => o))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
