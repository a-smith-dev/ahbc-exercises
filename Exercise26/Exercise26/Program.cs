using System;
using System.Text.RegularExpressions;

namespace Exercise26
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter some text: ");
                var letters = Console.ReadLine().ToCharArray();
                Console.WriteLine($"There were {NumOfVowels(letters)} vowels.");
                Console.Write("Would you like to continue? (y/n) ");
            } while (ValidateYesNo(Console.ReadLine()) == "y");
        }

        private static int NumOfVowels(char[] response)
        {
            var num = 0;
            for (int i = 0; i < response.Length; i++)
            {
                if (Regex.IsMatch($"{response[i]}", "[aeiou]"))
                {
                    num++;
                }
            }
            return num;
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
