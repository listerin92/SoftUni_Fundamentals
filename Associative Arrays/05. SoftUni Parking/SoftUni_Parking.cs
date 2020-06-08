using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class SoftUni_Parking
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingValidation = new Dictionary<string, string>();
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string cmd = command[0];
                switch (cmd)
                {
                    case "register":
                        {
                            string username = command[1];
                            string licensePlateNumber = command[2];
                            if (parkingValidation.ContainsKey(username))
                            {
                                string val = string.Empty;
                                parkingValidation.TryGetValue(username, out val);
                                Console.WriteLine($"ERROR: already registered with plate number {val}");
                                break;
                            }
                            if (!parkingValidation.ContainsKey(username))
                            {
                                parkingValidation.Add(username, licensePlateNumber);
                                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                            }
                            
                            parkingValidation[username] = licensePlateNumber;

                            break;
                        }
                    case "unregister":
                        {
                            string username = command[1];

                            bool result = parkingValidation.Remove(username);
                            if (result)
                            {
                                Console.WriteLine($"{username} unregistered successfully");
                            }
                            else
                            {
                                Console.WriteLine($"ERROR: user {username} not found");
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            foreach (var item in parkingValidation)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
