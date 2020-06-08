using System;
using System.Linq;
using System.Text;

namespace _01._Secret_Chat
{
    class Secret_Chat
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "Reveal")
            {
                string[] tokens = commands.Split(":|:").ToArray();
                string command = tokens[0];
                switch (command)
                {
                    case "InsertSpace":
                        {
                            int index = int.Parse(tokens[1]);
                            message = message.Insert(index, " ");
                            Console.WriteLine(message);
                            break;
                        }
                    case "Reverse":
                        {
                            string subStr = tokens[1];
                            bool isItThere = message.Contains(subStr);
                            if (isItThere)
                            {
                                string reverseStr = ReverseString(subStr);
                                int index = message.IndexOf(subStr);
                                int length = subStr.Length;
                                message = message.Remove(index, length);
                                message += reverseStr;
                                Console.WriteLine(message);
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                            break;
                        }
                    case "ChangeAll":
                        {
                            string subStr = tokens[1];
                            string replacementStr = tokens[2];
                            message = message.Replace(subStr, replacementStr);
                            Console.WriteLine(message);
                            break;
                        }
                    default:
                        break;
                }

            }
            Console.WriteLine($"You have a new text message: {message}");


        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
