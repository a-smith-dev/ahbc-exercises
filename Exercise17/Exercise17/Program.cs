using System;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a height for the triangle: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Not a number.");
            }

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
