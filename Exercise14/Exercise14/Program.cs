using System;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            bool isNumber;
            string repeater;
            do
            {
                do
                {
                    Console.Write("Enter a number: ");
                    isNumber = double.TryParse(Console.ReadLine(), out number);
                } while (!isNumber);
                for (double i = 1; i <= number; i++)
                {
                    Console.Write($"{Math.Pow(i, 2)} ");
                }
                Console.Write("\nWould you like to continue (y/n)? ");
                repeater = Console.ReadLine().ToUpper();
            } while (repeater == "Y");
        }
    }
}
