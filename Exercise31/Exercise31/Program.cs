using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise31
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 8, 0, 24, 51 };
            do
            {
                Console.WriteLine("Enter an index of the list: ");
                var input = ValidateNumber(Console.ReadLine());
                Console.WriteLine($"The value at index {input} is {list[input]}");
            } while (ValidateYesNo(Console.ReadLine()) == "y");

        }

        private static int ValidateNumber(string input)
        {
            var number = -1;
            while (number < 0)
            {
                while (!int.TryParse(input, out number))
                {
                    Console.Write("Please enter an index between 0 and 4 inclusive: ");
                    input = Console.ReadLine();
                }
                input = "";
            }

            return number;
        }

        private static string ValidateYesNo(string input)
        {
            input = input.ToLower();
            while (!Regex.IsMatch($"{input}", "^[yn]$"))
            {
                Console.Write("Please enter y or n: ");
                input = Console.ReadLine().ToLower();
            }
            return input;
        }
    }
}
