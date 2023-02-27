using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;

            // clears out the console beforehand
            Console.Clear();
            Console.WriteLine("Guess the secret number");

            for (int i = 0; i < 4; i++)

            {
                string input = Console.ReadLine();
                // Console.WriteLine(input); No longer display the user's guess.

                int parsedInput = int.Parse(input);

                if (parsedInput == secretNumber)
                {
                    Console.WriteLine($"Your guess correct. Guess number {i + 1}");
                    // stops from looping
                    break;
                }
                else
                {
                    Console.WriteLine($"Your guess is incorrect. Guess number {i + 1}");
                }

            };


        }

    }
}
