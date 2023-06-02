using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            Console.WriteLine("Welcome to the Number Guessing Game!");

            while (playAgain)
            {
                Console.Write("Enter the minimum number for the range: ");
                int min = int.Parse(Console.ReadLine());

                Console.Write("Enter the maximum number for the range: ");
                int max = int.Parse(Console.ReadLine());

                Random random = new Random();
                int targetNumber = random.Next(min, max + 1);
                int attempts = 0;
                bool guessedCorrectly = false;

                Console.WriteLine($"I'm thinking of a number between {min} and {max}. Can you guess it?");

                while (!guessedCorrectly && attempts < 5)
                {
                    Console.Write("Enter your guess: ");
                    int guess = int.Parse(Console.ReadLine());

                    if (guess == targetNumber)
                    {
                        guessedCorrectly = true;
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try again.");
                    }

                    attempts++;
                }

                if (guessedCorrectly)
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                }
                else
                {
                    Console.WriteLine($"Sorry, you couldn't guess the number. It was {targetNumber}.");
                }

                Console.Write("Do you want to play again? (yes/no): ");
                string playAgainInput = Console.ReadLine();
                playAgain = playAgainInput.ToLower() == "yes";

                Console.Clear();
            }

            Console.WriteLine("Thank you for playing the Number Guessing Game. Goodbye!");
        }
    }
}
