using System;

namespace Exercise75
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an algorithm that calculates the square root of a number.
            // Just Google It if you are stuck. Do not use the built in Math.Sqrt method.
            // The algorithm initially only needs to work for perfect squares.

            var number = 0;

            do
            {
                Console.Write("Please enter a positive number to check if it's a perfect square: ");
                int.TryParse(Console.ReadLine(), out number);
                if (number < 1)
                {
                    number = 0;
                }
                if (IsPerfectSquare(number))
                {

                    Console.WriteLine($"That's a perfect square! The Square Root of {number} is {SquareRoot(number)}");
                }
            } while (true);


        }


        private static int SquareRoot(int number)
        {
            if (number < 1)
            {
                return 0;
            }

            for (int i = 1; i < int.MaxValue; i++)
            {
                if (number / i == i)
                {
                    return i;
                }
                if (number / i < i)
                {
                    return 0;
                }
            }

            return 0;
        }

        private static bool IsPerfectSquare(int number)
        {
            return SquareRoot(number) != 0;
        }

    }
}
