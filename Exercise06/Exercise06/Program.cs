using System;
using System.Text.RegularExpressions;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Would you like to continue (y/n)? ");
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
