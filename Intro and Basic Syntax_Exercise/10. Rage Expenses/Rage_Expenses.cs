using System;

namespace _10._Rage_Expenses
{
    class Rage_Expenses
    {
        static void Main(string[] args)
        {
            int LostGamesCount = int.Parse(Console.ReadLine());
            double HeadsetPrice = double.Parse(Console.ReadLine());
            double MousePrice = double.Parse(Console.ReadLine());
            double KeyboardPrice = double.Parse(Console.ReadLine());
            double DisplayPrice = double.Parse(Console.ReadLine());


            int trashedHeaset = LostGamesCount / 2;
            int trashedMouse = LostGamesCount / 3;
            int trashedKeyboard = trashedHeaset / trashedMouse;
            int trashedDisplay = trashedKeyboard / 2;
            double expenses = HeadsetPrice * trashedHeaset +
                              MousePrice * trashedMouse +
                              KeyboardPrice * trashedKeyboard +
                              DisplayPrice * trashedDisplay;

            Console.WriteLine($"Rage expenses: {expenses:0.00} lv.");
            /* not ok, trashed keyboards and displays */
        }
    }
}

