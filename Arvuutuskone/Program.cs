using System;

namespace Arvuutuskone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string inputUser1;
            string inputUser2;
            int guess;
            Console.WriteLine("User 1, enter a number between 0 and 100:");
            inputUser1 = Console.ReadLine();
            number = Convert.ToInt32(inputUser1);
            Console.Clear();
            Console.WriteLine("User 2, guess the number.");
            inputUser2 = Console.ReadLine();
            guess = Convert.ToInt32(inputUser2);
            while (number != guess)
            {
                if (number == guess)
                {
                    break;
                }

                else if (number < guess)
                {
                    Console.WriteLine(inputUser2 + " is too high.");
                    Console.WriteLine("What is your next guess?");
                }

                else if (number > guess)
                {
                    Console.WriteLine(inputUser2 + " is too low.");
                    Console.WriteLine("What is your next guess?");

                }
                inputUser2 = Console.ReadLine();
                guess = Convert.ToInt32(inputUser2);
            }
            Console.WriteLine("You guessed the number!");
            {

            }
        }
    }
}