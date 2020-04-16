using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = "";
            do
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Would you like to continue (y/n)? ");
                response = Console.ReadLine();
                response = response.ToUpper();
            } while (response == "Y");
        }
    }
}
