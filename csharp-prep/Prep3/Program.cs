using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            // Generate a random magic number from 1 to 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guess = -1;
            int numOfGuesses = 0;

            // Loop until the user guesses the magic number
            while (guess != magicNumber)
            {
                // Ask the user for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numOfGuesses++;

                // Determine if the user needs to guess higher or lower, or if they guessed it
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {numOfGuesses} guesses!");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";
        }
    }
}
