using System;

namespace _05._Login
{
    class Login
    {
        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        static void Main(string[] args)
        {
            var user = Console.ReadLine();
            var noOfTries = 0;
            while (true)
            {
                var pass = Console.ReadLine();
                var reverse = ReverseString(pass);
                noOfTries++;
                if (noOfTries == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                }

                if (user.Length == 0 || reverse.Length == 0)
                {
                    Console.WriteLine();
                }
                else if (user == reverse)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

            }
        }
    }
}
