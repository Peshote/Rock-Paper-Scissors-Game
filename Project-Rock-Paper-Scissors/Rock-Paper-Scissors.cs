using System;

namespace Project_Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                const string Rock = "Rock";
                const string Paper = "Paper";
                const string Scissors = "Scissors";

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                Console.ResetColor();

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
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"You chose: {playerMove}.");
                Console.ResetColor();

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

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"The computer chose: {computerMove}.");
                Console.ResetColor();

                if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You win!");
                    Console.ResetColor();
                }
                else if ((playerMove == Rock && computerMove == Paper) || (playerMove == Paper && computerMove == Scissors) || (playerMove == Scissors && computerMove == Rock))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("It's a Draw!");
                    Console.ResetColor();
                }

                string playAgain;
                do
                {
                    Console.Write("Play again? [y]es or [n]o: ");
                    playAgain = Console.ReadLine().ToLower();
                } while (playAgain != "y" && playAgain != "yes" && playAgain != "n" && playAgain != "no");

                if (playAgain == "n" || playAgain == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
            }
        }
    }
}