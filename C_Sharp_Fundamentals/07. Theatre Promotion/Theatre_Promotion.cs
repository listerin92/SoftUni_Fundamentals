using System;

namespace _07._Theatre_Promotion
{
    class Theatre_Promotion
    {
        static void Main()
        {
            var typeofDays = Console.ReadLine().ToLower();
            var age = short.Parse(Console.ReadLine());
            var price = 0;

            if (typeofDays == "weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                { price = 12; }
                else if (age > 18 && age <= 64) { price = 18; }

            }
            if (typeofDays == "weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                { price = 15; }
                else if (age > 18 && age <= 64) { price = 20; }
            }
            if (typeofDays == "holiday")
            {
                if (age >= 0 && age <= 18) { price = 5; }
                else if (age > 18 && age <= 64) { price = 12; }
                else if (age > 64 && age <= 122) { price = 10; }

            }

            if (age < 0 || age > 122) { Console.WriteLine("Error!"); }
            else
                Console.WriteLine("{0}$", price);


        }
    }
}

