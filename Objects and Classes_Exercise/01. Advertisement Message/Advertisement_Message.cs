using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    class Advertisement_Message
    {
        class Message
        {
            public Message()
            {
                Phrases = new List<string>()
                { "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."
                };
                Events = new List<string>()
                { "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
                };
                Authors = new List<string>()
                { "Diana", "Petya", "Stella",
                    "Elena", "Katya", "Iva", "Annie", "Eva" };
                Cities = new List<string>()
                { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            }
            public List<string> Phrases { get; set; }
            public List<string> Events { get; set; }
            public List<string> Authors { get; set; }
            public List<string> Cities { get; set; }

        }
        static void Main(string[] args)
        {
            Message msg = new Message();
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Random rnd = new Random();
                int randomIdexPhrses = rnd.Next(msg.Phrases.Count);
                int randomIdexEvent = rnd.Next(msg.Events.Count);
                int randomIdexAuthors = rnd.Next(msg.Authors.Count);
                int randomIdexCities = rnd.Next(msg.Cities.Count);
                Console.WriteLine($"{msg.Phrases[randomIdexPhrses]} {msg.Events[randomIdexEvent]} {msg.Authors[randomIdexAuthors]} - {msg.Cities[randomIdexCities]}");

            }

        }
    }
}
