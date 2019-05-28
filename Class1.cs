using System;

namespace NumberGuesser_Moose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Moose Archer";

            // Changes console font color
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Better way of using variable values in a string; elimates need for second parameter references after the string
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            // Reset text color
            Console.ResetColor();

            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user's name
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello, {inputName}, let's play a game!");

            // Set initial correct number
            int correctNumber = 7;

            // Initial guess 
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10:");

            // While guess isn't correct
            while (guess != correctNumber)
            {
                // Get users input
                string input = Console.ReadLine();

                // Check if it's a number
                if (!int.TryParse(input, out guess))
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Error handing for if user enters a NAN
                    Console.WriteLine("That's not a number, please try again:");

                    // Reset text color
                    Console.ResetColor();

                    // Keeps going through code
                    continue;
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                if (guess != correctNumber)
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Message if user guesses wrong number
                    Console.WriteLine("Wrong number, please try again:");

                    // Reset text color
                    Console.ResetColor();
                }

            }

            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Message if user guesses wrong number
            Console.WriteLine("CONGRATULATIONS! YOU WIN....... NOTHING :-)");

            // Reset text color
            Console.ResetColor();
        }
    }
}
