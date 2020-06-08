using System;

namespace _03._Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var NoOfPersons = int.Parse(Console.ReadLine());
            var DiscountType = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();
            double totalPrice=0;

            if (DiscountType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 8.45 * NoOfPersons;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 9.8 * NoOfPersons;
                }
                else 
                {
                    totalPrice = 10.46 * NoOfPersons;
                }
                    if (NoOfPersons >= 30)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                Console.WriteLine("Total price: {0:0.00}", totalPrice);
            }
            else if (DiscountType == "Business")
            {
                    if (NoOfPersons >= 100)
                    {
                        NoOfPersons -= 10;
                    }
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 10.9 * NoOfPersons;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 15.6 * NoOfPersons;
                }
                else
                {
                    totalPrice = 16 * NoOfPersons;
                }

                Console.WriteLine("Total price: {0:0.00}", totalPrice);
            }
            else if(DiscountType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 15 * NoOfPersons;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 20 * NoOfPersons;
                }
                else
                {
                    totalPrice = 22.50 * NoOfPersons;
                }
                    if (NoOfPersons >= 10 && NoOfPersons <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                Console.WriteLine("Total price: {0:0.00}", totalPrice);
            }
            
        }
    }
}
