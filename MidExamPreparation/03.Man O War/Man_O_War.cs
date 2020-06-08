using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Man_O_War
{ // 90 ot 100
    class Man_O_War
    {
        static void Main(string[] args)
        {
            List<int> statusOfPirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            List<int> statusOfWarShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            int maxHealthCapacity = int.Parse(Console.ReadLine());

            string commandLine = string.Empty;
            bool terminatedWarShip = false;
            bool terminatedPirateShip = false;

            while ((commandLine = Console.ReadLine()) != "Retire")
            {
                string[] commandSplit = commandLine.Split().ToArray();
                string command = commandSplit[0];

                terminatedWarShip = BombardWarShip(statusOfWarShip, commandSplit, command);
                if (terminatedWarShip)
                {
                    break;
                }

                terminatedPirateShip = BombardPirateShip(statusOfPirateShip, commandSplit, command);
                if (terminatedPirateShip)
                {
                    break;
                }

                RepairPirateShip(statusOfPirateShip, maxHealthCapacity, commandSplit, command);

                Status(statusOfPirateShip, maxHealthCapacity, command);

            }

            if ((terminatedPirateShip == false) && (terminatedWarShip == false)) // stalemate - if both noth sunk
            {
                Final(statusOfPirateShip, statusOfWarShip);
            }

        }

        private static void Final(List<int> statusOfPirateShip, List<int> statusOfWarShip)
        {
            int pirateShipSum = 0;
            int warShipSum = 0;
            foreach (var item in statusOfPirateShip)
            {
                pirateShipSum += item;
            }
            foreach (var item in statusOfWarShip)
            {
                warShipSum += item;
            }
            Console.WriteLine($"Pirate ship status: {pirateShipSum}");
            Console.WriteLine($"Warship status: {warShipSum}");
        }

        private static void Status(List<int> statusOfPirateShip, int maxHealthCapacity, string command)
        {
            if (command == "Status")
            {
                double twentypercent = maxHealthCapacity * 0.2;
                int sectionsNeedRepair = 0;
                foreach (var item in statusOfPirateShip)
                {
                    if (item < twentypercent)
                    {
                        sectionsNeedRepair++;
                    }
                }
                if (sectionsNeedRepair > 0)
                {
                    Console.WriteLine($"{sectionsNeedRepair} sections need repair.");
                }
            }
        }

        private static void RepairPirateShip(List<int> statusOfPirateShip, int maxHealthCapacity, string[] commandSplit, string command)
        {
            if (command == "Repair")
            {
                int index = int.Parse(commandSplit[1]);
                int health = int.Parse(commandSplit[2]);
                if ((index >= 0) && (index <= statusOfPirateShip.Count - 1))
                {
                    if (statusOfPirateShip[index] <= maxHealthCapacity)
                    {
                        statusOfPirateShip[index] += health;

                    }
                }
            }
        }

        private static bool BombardWarShip(List<int> statusOfWarShip, string[] commandSplit, string command)
        {
            if (command == "Fire")
            {
                int index = int.Parse(commandSplit[1]);
                int attackPower = int.Parse(commandSplit[2]);

                if ((index >= 0) && (index <= statusOfWarShip.Count - 1))
                {
                    statusOfWarShip[index] -= attackPower;

                    if (statusOfWarShip[index] <= 0)// if section is broken
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool BombardPirateShip(List<int> statusOfPirateShip, string[] commandSplit, string command)
        {
            if (command == "Defend")
            {
                int startIndex = int.Parse(commandSplit[1]);
                int endIndex = int.Parse(commandSplit[2]);
                int attackPower = int.Parse(commandSplit[3]);

                if ((startIndex >= 0) && (endIndex <= statusOfPirateShip.Count - 1)) // only inside index range
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        statusOfPirateShip[i] -= attackPower;

                        if (statusOfPirateShip[i] <= 0) // if section is broken
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
