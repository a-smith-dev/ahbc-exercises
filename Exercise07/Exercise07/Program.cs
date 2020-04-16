using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            var repeater = "";
            var response = "";
            do
            {
                Console.Write("Enter some text: ");
                repeater = Console.ReadLine();
                Console.WriteLine(repeater);
                Console.Write("Would you like to continue (y/n)? ");
                response = Console.ReadLine();
                response = response.ToUpper();
            } while (response == "Y");
        }
    }
}
