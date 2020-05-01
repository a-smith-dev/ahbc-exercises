using System;
using System.Text.RegularExpressions;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number: ");
                double number = ValidateDouble(Console.ReadLine());
                for (double i = 1; i <= number; i++)
                {
                    Console.Write($"{Math.Pow(i, 2)} ");
                }
                Console.Write("\nWould you like to continue (y/n)? ");
            } while (ValidateYesNo(Console.ReadLine()) == "y");
        }

        static double ValidateDouble(string response)
        {
            double number = -1;
            while (number < 1)
            {
                while (!double.TryParse(response, out number))
                {
                    Console.Write("Please enter a positive number: ");
                    response = Console.ReadLine();
                }
                response = "";
            }
            return number;
        }

        static string ValidateYesNo(string response)
        {
            response = response.ToLower();
            while (!Regex.IsMatch($"{response}", "^[yn]$"))
            {
                Console.Write("Please enter y or n: ");
                response = Console.ReadLine().ToLower();
            }
            return response;
        }
    }
}
