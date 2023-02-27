using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);
            Console.WriteLine(secretNumber);


            // clears out the console beforehand
            // Console.Clear();
            Console.WriteLine("Guess the secret number");

            for (int i = 0; i < 4; i++)

            {
                string input = Console.ReadLine();
                // Console.WriteLine(input); No longer display the user's guess.

                int parsedInput = int.Parse(input);

                int guessLeft = 4 - (i + 1);

                if (parsedInput == secretNumber)
                {
                    Console.WriteLine($"Your guess correct. You have {guessLeft} guesses remaining.");
                    // stops from looping
                    break;
                }
                else
                {
                    Console.WriteLine($"Your guess is incorrect. You have {guessLeft} guesses remaining.");
                }

            };


        }

    }
}
