using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {

                List<string> addOrPassenger = input.Split().ToList();

                int numberOfPassengers;
                bool pasengersTry = false;

                //if 0 element is digit then this is No of Passengers
                if (pasengersTry = Int32.TryParse(addOrPassenger[0], out numberOfPassengers))
                {
                    for (int i = 0; i < train.Count; i++)
                    {
                        if ((maxCapacity - train[i]) >= numberOfPassengers)
                        {
                            train[i] += numberOfPassengers;
                            break;
                        }
                    }

                }
                else
                {
                    //else 1th element is digit and this means Add a vagon with 1th(number of passengers)
                    pasengersTry = Int32.TryParse(addOrPassenger[1], out numberOfPassengers);

                    train.Add(numberOfPassengers);

                }
            }
            Console.WriteLine(string.Join(" ", train));

        }
    }
}

