using System;
using System.Text.RegularExpressions;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number: ");
                int input = ValidateInt(Console.ReadLine());
                for (int i = input; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }
                Console.Write("\nWould you like to continue (y/n)? ");
            } while (ValidateYesNo(Console.ReadLine()) == "y");
        }

        static int ValidateInt(string response)
        {
            var number = -1;
            while (number < 0)
            {
                while (!int.TryParse(response, out number))
                {
                    Console.Write("Please enter a non-negative integer: ");
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
