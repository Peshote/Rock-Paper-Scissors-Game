using System;

namespace Project_Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables to keep track of game statistics
            int playerWins = 0;
            int computerWins = 0;
            int drawGames = 0;

            // Main game loop
            while (true)
            {
                const string Rock = "Rock";
                const string Paper = "Paper";
                const string Scissors = "Scissors";

                // Prompt the player to choose rock, paper, or scissors
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                Console.ResetColor();

                string playerMove = Console.ReadLine();

                // Convert player input to standardized format
                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    // Invalid input; prompt player to try again
                    Console.WriteLine("Invalid Choice! Try Again...");
                    continue; // Restart the loop for another input
                }

                // Display the player's choice
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"You chose: {playerMove}.");
                Console.ResetColor();

                // Generate a random move for the computer
                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = "";

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }

                // Display the computer's choice
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"The computer chose: {computerMove}.");
                Console.ResetColor();

                // Determine the winner of the round and update statistics
                if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper))
                {
                    // Player wins
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You Win!");
                    Console.ResetColor();
                    playerWins++;
                }
                else if ((playerMove == Rock && computerMove == Paper) || (playerMove == Paper && computerMove == Scissors) || (playerMove == Scissors && computerMove == Rock))
                {
                    // Computer wins
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Lose!");
                    Console.ResetColor();
                    computerWins++;
                }
                else
                {
                    // It's a draw
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("It's a Draw!");
                    Console.ResetColor();
                    drawGames++;
                }

                // Display current statistics
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Current Statistic:");
                Console.WriteLine($"You Won: {playerWins} times");
                Console.WriteLine($"Computer Won: {computerWins} times");
                Console.WriteLine($"The game was Even: {drawGames} times");
                Console.ResetColor();

                // Prompt player to play again
                Console.ForegroundColor = ConsoleColor.Cyan;
                string playAgain;
                do
                {
                    Console.Write("Play again? [y]es or [n]o: ");
                    playAgain = Console.ReadLine().ToLower();
                } while (playAgain != "y" && playAgain != "yes" && playAgain != "n" && playAgain != "no");

                if (playAgain == "n" || playAgain == "no")
                {
                    // Player chose not to play again; end the game
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
            }
        }
    }
}