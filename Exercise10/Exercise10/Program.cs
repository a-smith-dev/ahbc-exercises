using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal minHeight = 54;
            var height = 0.0m;
            var difference = height;
            var repeatResponse = "";

            do
            {

                Console.Write("Enter your height in inches: ");
                height = Convert.ToDecimal(Console.ReadLine());

                if (height < minHeight)
                {
                    difference = minHeight - height;
                    Console.WriteLine("Sorry, you cannot ride the Raptor. You need " + difference +
                        " more inches.");
                }
                else
                {
                    Console.WriteLine("Great, you can ride the Raptor!");
                }
                Console.Write("Would you like to continue (y/n) ");
                repeatResponse = Console.ReadLine();
                repeatResponse = repeatResponse.ToUpper();
            } while (repeatResponse == "Y");
        }
    }
}
