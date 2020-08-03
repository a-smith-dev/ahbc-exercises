using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exercise51
{
    class Program
    {
        static void Main(string[] args)
        {
            var translations = new Dictionary<string, string>();
            translations.Add("hello", "hola");
            translations.Add("food", "comida");
            translations.Add("world", "mundo");
            translations.Add("computer", "computadora");
            translations.Add("exercise", "ejercicio");

            do
            {
                Console.Write("Enter a word in English: ");
                var response = Console.ReadLine().ToLower();
                if (translations.ContainsKey(response))
                {
                    translations.TryGetValue(response, out string spanish);
                    Console.WriteLine($"{response} in Spanish is {spanish}");
                }
                else
                {
                    Console.WriteLine($"{response} cannot be translated.");
                }
                Console.Write("Would you like to continue? (y/n) ");

            } while (Console.ReadLine().ToLower() == "y");


        }
    }
}
