using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Teamwork_Project
    {
        static void Main(string[] args)
        {
            int countOfTeamsToRegister = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            for (int i = 0; i < countOfTeamsToRegister; i++)
            {
                string[] tokens = Console.ReadLine().Split("-").ToArray();
                string userCreator = tokens[0];
                string teamname = tokens[1];
                Team team = new Team(userCreator, teamname);
                teams.Add(team);
            }
            string end = string.Empty;

            while ((end = Console.ReadLine()) != "end of assignment")
            {

                string[] tokens = end.Split("->").ToArray();
                string userToJoin = tokens[0];
                string teamname = tokens[1];
                Team team = new Team(userToJoin, teamname);
                teams.Add(team);
            }
            foreach (var team in teams)
            {
                Console.WriteLine($"Team {team.Teamname} has been created by {team.User}!");

            }
        }
    }
    class Team
    {
        public Team(string user, string teamname)
        {
            User = user;
            Teamname = teamname;
        }
        public string User { get; set; }
        public string Teamname { get; set; }

    }
}
