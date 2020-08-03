using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise42
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter an X coordinate: ");
                var x = ValidateNumber();
                Console.Write("Enter a Y coordinate: ");
                var y = ValidateNumber();
                var point1 = new Point(x, y);
                point1.Created();
                Console.Write("Would you like to continue? (y/n) ");
            } while (ValidateYesNo(Console.ReadLine()) == "y");
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

        static int ValidateNumber()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
                Console.Write("Please enter an integer: ");
            }
        }
    }
}
