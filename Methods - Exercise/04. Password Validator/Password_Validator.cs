using System;
using System.Text;

namespace _04._Password_Validator
{
    class Password_Validator
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string result = Print(password);
            Console.WriteLine(result);
            // using return bool for all methods will simplify printing
        }
        private static string Print(string password)
        {
            StringBuilder result = new StringBuilder();
            if (!String.IsNullOrEmpty(CheckLength(password)))
            {
                result.Append(CheckLength(password));
                result.Append("\n");
            }
            if (!String.IsNullOrEmpty(CheckLetterOrDigits(password)))
            {
                result.Append(CheckLetterOrDigits(password));
                result.Append("\n");
            }
            if (!String.IsNullOrEmpty(AtLeastTwoDigits(password)))
            {
                result.Append(AtLeastTwoDigits(password));
                result.Append("\n");
            }
            if (String.IsNullOrEmpty(CheckLength(password)) == true &&
                String.IsNullOrEmpty(CheckLetterOrDigits(password)) == true &&
                String.IsNullOrEmpty(AtLeastTwoDigits(password)) == true)
            {
                result.Append("Password is valid");
                result.Append("\n");
            }
            return result.Remove(result.Length-1,1).ToString();//remove last \n

        }
        private static string CheckLength(string password)
        {
            char[] length = password.ToCharArray();
            if (length.Length < 6 || length.Length > 10)
            {
                return "Password must be between 6 and 10 characters";
            }
            return "";
        }
        private static string CheckLetterOrDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!(char.IsLetterOrDigit(password[i])))
                {
                    return "Password must consist only of letters and digits";
                }
            }
            return "";
        }
        private static string AtLeastTwoDigits(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    count++;
                }
            }
            if (count < 2)
            {
                return "Password must have at least 2 digits";
            }
            else return "";

        }
    }
}
