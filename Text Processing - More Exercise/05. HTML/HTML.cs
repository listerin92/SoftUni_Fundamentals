using System;
using System.Text;

namespace _05._HTML
{
    class HTML
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<h1>");
            string title = Console.ReadLine();
            sb.AppendLine(title);
            sb.AppendLine("</h1>");
            
            sb.AppendLine("<article>");
            string article = Console.ReadLine();
            sb.AppendLine(article);
            sb.AppendLine("</article>");

            string comment = string.Empty;
            while ((comment = Console.ReadLine()) != "end of comments")
            {
                sb.AppendLine("<div>");
                sb.AppendLine(comment);
                sb.AppendLine("</div>");
            }
            Console.WriteLine(sb);
        }
    }
}
