using System;
using System.Linq;

namespace _03._Extract_File
{
    class Extract_File
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split('\\').ToArray();

            string[] fileName = path[path.Length-1].Split('.').ToArray();
            Console.WriteLine($"File name: {fileName[0]}");
            Console.WriteLine($"File extension: {fileName[1]}");
        }
    }
}
