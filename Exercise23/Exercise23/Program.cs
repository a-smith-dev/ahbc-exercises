using System;

namespace Exercise23
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                Console.Write("Enter some text: ");
                response = Console.ReadLine();
                for (int i = 0; i < 10; i++)
                {
                    if (response.Length - 1 < 10)
                    {
                        Console.Write(response);
                        break;
                    }
                    else
                    {
                        Console.Write(response[i]);
                    }
                }
                Console.Write("\nWould you like to continue (y/n)? ");
                response = Console.ReadLine().ToUpper();
            } while (response == "Y");
        }
    }
}
