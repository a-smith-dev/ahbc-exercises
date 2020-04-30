using System;

namespace Exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = new string[20];
            for (int i = 0; i < sentence.Length; i++)
            {
                 Console.Write("Enter a word: ");
                 sentence[i] = Console.ReadLine() + " ";
                 Console.Write("Would you like to enter another word (y/n)? ");
                 if (ValidateYesNo(Console.ReadLine()) != "y")
                 {
                     break;
                 }
            }
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == default)
                {
                    break;
                }
                Console.Write(sentence[i]);
            }
        }

        static string ValidateYesNo(string word)
        {
            word = word.ToLower();
            while (word != "y" && word != "n")
            {
                Console.Write("Please enter y or n: ");
                word = Console.ReadLine().ToLower();
            }
            return word;
        }
    }
}
