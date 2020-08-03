using System;
using System.Numerics;

namespace Exercise52
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape = null;
            int side1;
            int side2;
            int side3;
            int counter = 0;
            var avgArea = 0d;
            var avgPerimeter = 0d;
            string response;
            var valid = false;
            do
            {
                AskShape();
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        valid = true;
                        Console.Write("Enter a side length: ");
                        shape = new Square { SideLength = ValidateNumber(Console.ReadLine()) };
                        break;
                    case "2":
                        valid = true;
                        Console.Write("Enter side length 1: ");
                        side1 = ValidateNumber(Console.ReadLine());
                        Console.Write("Enter side length 2: ");
                        side2 = ValidateNumber(Console.ReadLine());
                        Console.Write("Enter side length 3: ");
                        side3 = ValidateNumber(Console.ReadLine());
                        shape = new Triangle { Side1 = side1, Side2 = side2, Side3 = side3 };
                        break;
                    case "3":
                        valid = true;
                        Console.Write("Enter a radius: ");
                        shape = new Circle { Radius = ValidateNumber(Console.ReadLine()) };
                        break;
                    case "q":
                        break;
                    default:
                        Console.Write("Invalid response. ");
                        break;
                }
                if (valid)
                {
                    valid = false;
                    counter++;
                    avgPerimeter += shape.GetPerimeter();
                    avgArea += shape.GetArea();
                }

            } while (response != "q");
            avgArea /= counter;
            avgPerimeter /= counter;
            Console.WriteLine($"Average Area: {avgArea}");
            Console.WriteLine($"Average Perimeter: {avgPerimeter}");
        }

        static int ValidateNumber(string response)
        {
            int number;
            while (!int.TryParse(response, out number) || number < 1)
            {
                Console.WriteLine("Please enter a positive number: ");
                response = Console.ReadLine();
            };
            return number;
        }

        static void AskShape()
        {
            Console.Write("Enter a new shape. Square (1), Triangle (2), Circle (3), Quit (q): ");
        }
    }
}
