using System;
using System.Text.RegularExpressions;

namespace Exercise27
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter some text: ");
                var letters = Console.ReadLine().ToCharArray();
                Console.WriteLine($"There were {NumOfConsonants(letters)} consonants.");
                Console.Write("Would you like to continue? (y/n)");
            } while (ValidateYesNo(Console.ReadLine()) == "y");
        }

        private static int NumOfConsonants(char[] letters)
        {
            var counter = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                if (Regex.IsMatch($"{letters[i]}", "[bcdfghjklmnpqrstvwxyz]"))
                    counter++;
            }
            return counter;
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
