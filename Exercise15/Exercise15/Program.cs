using System;
using System.Text.RegularExpressions;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            bool isNumber;
            string repeater;
            bool isRepeater;
            do
            {
                do
                {
                    Console.Write("Enter a number: ");
                    isNumber = double.TryParse(Console.ReadLine(), out number);
                } while (!isNumber);
                for (double i = 1; i <= number; i++)
                {
                    Console.Write($"{Math.Pow(i, 3)} ");
                }
                do
                {
                    Console.Write("\nWould you like to continue (y/n)? ");
                    repeater = Console.ReadLine().ToUpper();
                    isRepeater = Regex.IsMatch($"{repeater}", "[YN]");
                } while (!isRepeater);
            } while (repeater == "Y");
        }
    }
}