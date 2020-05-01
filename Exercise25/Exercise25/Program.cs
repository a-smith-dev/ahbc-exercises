using System;
using System.Text.RegularExpressions;

namespace Exercise25
{
    class Program
    {
        static void Main(string[] args)
        {
            // using string.Split() to chop up a single sentence string
            // into individual words.
            do
            {
                Console.Write("Enter a sentence: ");
                var responseArray = Console.ReadLine().Split(" ");
                for (int i = 0; i < responseArray.Length; i++)
                {
                    Console.WriteLine(responseArray[i]);
                }
                Console.Write("\nWould you like to continue (y/n)? ");
            } while (ValidateYesNo(Console.ReadLine()) == "y");
        }

        private static string ValidateYesNo(string response)
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
