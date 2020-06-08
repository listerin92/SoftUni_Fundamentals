using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_In_30_Minutes
{
    class Back_In_30_Minutes
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 30;
            if(minutes > 59)
            {
                hour += 1;
                minutes -=60;
            }
            if (hour > 23) hour -= 24;
            Console.WriteLine("{0}:{1:00}", hour, minutes);
        }
    }
}
