using System;

namespace _09._Greater_of_Two_Values
{
    class Greater_of_Two_Values
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string val1 = Console.ReadLine();
            string val2 = Console.ReadLine();
            switch (str)
            {
                case "int":
                    int result = GetMax(int.Parse(val1), int.Parse(val2));
                    Console.WriteLine(result);
                    break;
                case "char":
                    char resultChar = GetMax(char.Parse(val1), char.Parse(val2));
                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string resultStr = GetMax(val1, val2);
                    Console.WriteLine(resultStr);
                    break;
                default:
                    break;
            }

        }

        static int GetMax(int val1, int val2)
        {
            if (val1 > val2)
            {
                return val1;
            }
            return val2;
        }
        static char GetMax(char val1, char val2)
        {
            if (val1 > val2)
            {
                return val1;
            }
            return val2;
        }
        static string GetMax(string val1, string val2)
        {
            if (string.Compare(val1, val2)  > 0)
            {
                return val1;
            }
            return val2;
        }

    }
}
