using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class SoftUni_Exam_Results
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> examResults = new Dictionary<string, int>();
            Dictionary<string, int> submission = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input != "exam finished")
                {
                    string[] tokens = input.Split('-').ToArray();

                    string name = tokens[0];

                    if (tokens.Length > 2)
                    {
                        AddUserAndSubmission(examResults, submission, tokens, name);
                    }
                    else
                    {
                        BannedUser(examResults, tokens, name);
                    }
                }
                else
                {
                    break;
                }
            }

            Print(examResults, submission);
        }

        private static void AddUserAndSubmission(Dictionary<string, int> examResults
                                                , Dictionary<string, int> submission
                                                , string[] tokens
                                                , string name)
        {
            string course = tokens[1];
            int score = int.Parse(tokens[2]);

            if (!examResults.ContainsKey(name))
            {
                examResults.Add(name, 0);
            }

            if (examResults[name] < score)
            {
                examResults[name] = score;
            }

            if (!submission.ContainsKey(course))
            {
                submission.Add(course, 0);
            }
            submission[course]++;
        }

        private static void BannedUser(Dictionary<string, int> examResults
                                        , string[] tokens
                                        , string name)
        {
            string banned = tokens[1];
            if (examResults.ContainsKey(name))
            {
                examResults.Remove(name);
            }
        }

        private static void Print(Dictionary<string, int> examResults
                                , Dictionary<string, int> submission)
        {
            Console.WriteLine("Results:");

            foreach (var results in examResults.OrderByDescending(o => o.Value).ThenBy(o => o.Key))
            {
                Console.WriteLine($"{results.Key} | {results.Value}");
            }
            Console.WriteLine("Submissions:");

            foreach (var subm in submission.OrderByDescending(o => o.Value).ThenBy(o => o.Key))
            {
                Console.WriteLine($"{subm.Key} - {subm.Value}");
            }
        }
    }
}
