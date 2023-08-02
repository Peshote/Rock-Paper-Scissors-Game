using System;

namespace Project_Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.ForegroundColor = ConsoleColor.Cyan; // Set foreground color to Cyan
            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            Console.ResetColor(); // Reset foreground color to default

            string playerMove = Console.ReadLine();

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
                Console.WriteLine("Invalid Choice! Try Again...");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green; // Set foreground color to Green
            Console.WriteLine($"You chose: {playerMove}.");
            Console.ResetColor(); // Reset foreground color to default

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

            Console.ForegroundColor = ConsoleColor.Magenta; // Set foreground color to Magenta
            Console.WriteLine($"The computer chose: {computerMove}.");
            Console.ResetColor(); // Reset foreground color to default

            if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper))
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // Set foreground color to Yellow
                Console.WriteLine("You win!");
                Console.ResetColor(); // Reset foreground color to default
            }
            else if ((playerMove == Rock && computerMove == Paper) || (playerMove == Paper && computerMove == Scissors) || (playerMove == Scissors && computerMove == Rock))
            {
                Console.ForegroundColor = ConsoleColor.Red; // Set foreground color to Red
                Console.WriteLine("You lose!");
                Console.ResetColor(); // Reset foreground color to default
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue; // Set foreground color to Blue
                Console.WriteLine("It's a Draw!");
                Console.ResetColor(); // Reset foreground color to default
            }
        }
    }
}