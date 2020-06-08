using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    partial class Vehicle_Catalogue
    {
        static void Main(string[] args)
        {
            var catalog = new Catalog();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                FillCatalog(catalog, command);
            }

            Print(catalog);

        }

        private static void Print(Catalog catalog)
        {
            if (catalog.Cars.Count != 0)
            {
                List<Car> sortedCars = catalog.Cars.OrderBy(o => o.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (var car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count != 0)
            {
                List<Truck> sortedTrucks = catalog.Trucks.OrderBy(o => o.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (var truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        private static void FillCatalog(Catalog catalog, string command)
        {
            string[] tokens = command.Split('/');
            var cars = new Car();
            var trucks = new Truck();
            if (tokens[0] == "Car")
            {
                cars.Brand = tokens[1];
                cars.Model = tokens[2];
                cars.HorsePower = int.Parse(tokens[3]);
                catalog.Cars.Add(cars);
            }
            else if (tokens[0] == "Truck")
            {
                trucks.Brand = tokens[1];
                trucks.Model = tokens[2];
                trucks.Weight = int.Parse(tokens[3]);
                catalog.Trucks.Add(trucks);
            }
        }
    }
}


