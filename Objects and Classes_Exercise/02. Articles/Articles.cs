using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _02._Articles
{
    class Articles
    {

        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(", ");
            Article article = new Article(tokens[0], tokens[1], tokens[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> commands = Console.ReadLine().Split(": ").ToList();
                string command = commands[0];
                string argument = commands[1];

                switch (commands[0])
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuther(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(article);

        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Author = author;
            Content = content;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuther(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }
        public override string ToString()
        {

            string res = $"{Title} - {Content}: {Author}";
            return res;
        }
    }
}
