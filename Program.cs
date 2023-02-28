using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // display a message to the user, asking them to guess the secret number
            Console.WriteLine("Guess the secret number");
            // display a prompt for the user's guess (--> ReadLine)
            //  take the user's guess as an input and save it as a variable (-->  input)
            string input = Console.ReadLine();
            // display the user's guess back to the screen
            Console.WriteLine(input);
        }

    }
}


