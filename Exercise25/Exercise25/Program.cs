using System;
using System.Linq;
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
                var responseList = Console.ReadLine().Split(" ").ToList();
                foreach (var word in responseList)
                {
                    Console.WriteLine(word);
                    // Below would also be valid, but unneccessary since word is a string.
                    // Console.WriteLine($"{word}");
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
