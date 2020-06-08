using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Articles_2_0
    {
        static void Main(string[] args)
        {


            int numberOfCommands = int.Parse(Console.ReadLine());

            List < Article > artList = new List<Article>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                Article article = new Article(tokens[0], tokens[1], tokens[2]);
                artList.Add(article);
            }
            string command = Console.ReadLine();

            switch (command)
            {
                case "title":
                    artList = artList.OrderBy(o => o.Title).ToList();
                    Print(artList);
                    break;
                case "content":
                    artList = artList.OrderBy(o => o.Content).ToList();
                    Print(artList);
                    break;
                case "author":
                    artList = artList.OrderBy(o => o.Author).ToList();
                    Print(artList);
                    break;
                default:
                    break;
            }
            Console.WriteLine();
        }

        private static void Print(List<Article> sortedByCase)
        {
            foreach (var item in sortedByCase)
            {
                Console.WriteLine(item.ToString());

            }
        }

        class Article
        {
            public Article()
            { }
            public Article(string title, string content, string author)
            {
                Title = title;
                Author = author;
                Content = content;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {

                string res = $"{Title} - {Content}: {Author}";
                return res;
            }
        }
    }
}
