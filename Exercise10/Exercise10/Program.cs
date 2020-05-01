using System;
using System.Text.RegularExpressions;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal minHeight = 54;
            do
            {
                Console.Write("Enter your height in inches: ");
                var height = ValidateDecimal(Console.ReadLine());
                if (height < minHeight)
                {
                    var difference = minHeight - height;
                    Console.WriteLine($"Sorry, you cannot ride the Raptor. You need {difference} more inches.");
                }
                else
                {
                    Console.WriteLine("Great, you can ride the Raptor!");
                }
                Console.Write("Would you like to continue (y/n) ");
            } while (ValidateYesNo(Console.ReadLine()) == "y");
        }

        static decimal ValidateDecimal(string response)
        {
            decimal number;
            while (!decimal.TryParse(response, out number))
            {
                Console.Write("Please enter a decimal");
                response = Console.ReadLine();
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
