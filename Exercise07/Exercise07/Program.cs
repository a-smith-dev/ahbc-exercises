using System;
using System.Text.RegularExpressions;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter some text: ");
                var repeater = Console.ReadLine();
                Console.WriteLine(repeater);
                Console.Write("Would you like to continue (y/n)? ");
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
    }
}
