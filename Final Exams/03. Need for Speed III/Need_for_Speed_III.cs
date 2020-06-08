using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Need_for_Speed_III
    {
        static void Main(string[] args)
        {
            int noOfCars = int.Parse(Console.ReadLine());

            List<Cars> cars = Input(noOfCars);

            string line = string.Empty;
            while ((line = Console.ReadLine()) != "Stop")
            {
                string[] tokens = line.Split(" : ").ToArray();
                string command = tokens[0];
                switch (command)
                {
                    case "Drive":
                        {
                            Drive(cars, tokens);
                            break;
                        }
                    case "Refuel":
                        {
                            Refuel(cars, tokens);
                            break;
                        }
                    case "Revert":
                        {
                            Revert(cars, tokens);
                            break;
                        }
                    default:
                        break;
                }
            }
            Print(cars);
        }

        private static void Print(List<Cars> cars)
        {
            foreach (var car in cars.OrderByDescending(o => o.Mileage))
            {
                Console.WriteLine($"{car.CarName} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        private static void Revert(List<Cars> cars, string[] tokens)
        {
            string carName = tokens[1];
            uint kilometers = uint.Parse(tokens[2]);
            foreach (var matchedCar in cars)
            {
                if (matchedCar.CarName == carName)
                {
                    if ((matchedCar.Mileage - kilometers) >= 10000)
                    {
                        matchedCar.Mileage -= kilometers;
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        matchedCar.Mileage = 10000;
                    }
                }
            }
        }

        private static void Refuel(List<Cars> cars, string[] tokens)
        {
            string carName = tokens[1];
            uint fuel = uint.Parse(tokens[2]);
            foreach (var matchedCar in cars)
            {
                if (matchedCar.CarName == carName)
                {
                    if (matchedCar.Fuel + fuel <= 75)
                    {
                        matchedCar.Fuel += fuel;
                    }
                    else
                    {
                        fuel = (75 - matchedCar.Fuel);
                        matchedCar.Fuel = 75;
                        
                        
                    }
                }
            }
            Console.WriteLine($"{carName} refueled with {fuel} liters");
        }

        private static List<Cars> Input(int noOfCars)
        {
            List<Cars> cars = new List<Cars>();
            for (int i = 0; i < noOfCars; i++)
            {
                string[] lineOfCarInfo = Console.ReadLine().Split('|').ToArray();
                string carName = lineOfCarInfo[0];
                uint distance = uint.Parse(lineOfCarInfo[1]);
                uint fuel = uint.Parse(lineOfCarInfo[2]);
                Cars car = new Cars(carName, distance, fuel);
                cars.Add(car);
            }
            return cars;
        }

        private static void Drive(List<Cars> cars, string[] tokens)
        {
            string carName = tokens[1];
            uint distance = uint.Parse(tokens[2]);
            uint fuel = uint.Parse(tokens[3]);
            Cars currentCar = new Cars(carName, distance, fuel);
            foreach (var matchedCar in cars)
            {
                if (matchedCar.CarName == currentCar.CarName)
                {
                    if (matchedCar.Fuel >= currentCar.Fuel)
                    {
                        Console.WriteLine($"{currentCar.CarName} driven for {currentCar.Mileage} kilometers. {currentCar.Fuel} liters of fuel consumed.");

                        if ((matchedCar.Mileage + currentCar.Mileage) >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {matchedCar.CarName}!");
                            cars.Remove(matchedCar);
                            break;
                        }
                        else
                        {
                            matchedCar.Mileage += currentCar.Mileage;
                        }
                        matchedCar.Fuel -= currentCar.Fuel;
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
            }
        }
    }
    class Cars
    {
        public Cars(string car, uint mileage, uint fuel)
        {
            CarName = car;
            Mileage = mileage;
            Fuel = fuel;
        }
        public string CarName { get; set; }
        public uint Mileage { get; set; }
        public uint Fuel { get; set; }

    }
}
