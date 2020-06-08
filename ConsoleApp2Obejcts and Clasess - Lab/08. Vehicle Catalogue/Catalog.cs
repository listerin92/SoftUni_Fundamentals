using System.Collections.Generic;

namespace _08._Vehicle_Catalogue
{
    partial class Vehicle_Catalogue
    {
        public class Catalog
        {
            public Catalog()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
            public List<Truck> Trucks { get; set; }
            public List<Car> Cars { get; set; }

        }
    }
}


