using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);
            int y = 0;
            Console.WriteLine(secretNumber);

            Console.WriteLine("Please choose a difficulty level: 1, 2, 3");
            Console.WriteLine("(1) Easy - this gives the user eight guesses.");
            Console.WriteLine("(2) Medium - this gives the user six guesses.");
            Console.WriteLine("(3) Hard - this gives the user four guesses.");

            string level = Console.ReadLine();

            if (level == "1")
            {
                y = 8;
            }
            if (level == "2")
            {
                y = 6;
            }
            if (level == "3")
            {
                y = 4;
            }


            // clears out the console beforehand
            // Console.Clear();
            Console.WriteLine("Guess the secret number");

            for (int i = 0; i < y; i++)

            {
                string input = Console.ReadLine();
                // Console.WriteLine(input); No longer display the user's guess.

                int parsedInput = int.Parse(input);

                int guessLeft = y - (i + 1);

                if (parsedInput == secretNumber)
                {
                    Console.WriteLine($"Your guess correct. You have {guessLeft} guesses remaining.");
                    // stops from looping
                    break;
                }
                if (parsedInput < secretNumber)
                {
                    Console.WriteLine($"Your guess is too low. You have {guessLeft} guesses remaining.");
                }
                if (parsedInput > secretNumber)
                {
                    Console.WriteLine($"Your guess is too high. You have {guessLeft} guesses remaining.");
                }




            };


        }

    }
}
