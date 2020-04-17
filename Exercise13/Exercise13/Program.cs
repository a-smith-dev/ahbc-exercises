using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            string repeater;

            do
            {
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());
                for (int i = input; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.Write("Would you like to continue (y/n)? ");
                repeater = Console.ReadLine().ToUpper();
            } while (repeater == "Y");
        }
    }
}
