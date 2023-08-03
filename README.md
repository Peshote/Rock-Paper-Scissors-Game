# The "Rock - Paper - Scissors" Game

Rock Paper Scissors is deceptively simple. Players choose three separate ways of conquering their opponent in a highly technical duel of the minds. A player forms their hands into iconic tools of destruction in an attempt to best their opponents in the quest for glory. Rock beats scissors, scissors beat paper, paper beats rock, and the cycle continues.

<img alt="Image" width="600px" src="https://www.science.org/do/10.1126/science.aac4663/abs/sn-rockpaper.jpg" />

# The Project:
A console-based C# implementation of "Rock - Paper - Scissors" Game

The game is a simple **Two Player Game**, where you and your oponent (the computer) simultaneously choose one of the following three options: **"Rock"**, **"Paper"** or **"Scissors"**. The rules are as follows:

  * **Rock beats Scissors** (the Scissors get broken by the Rock)
  * **Scissors beats Paper** (the Paper get cut by the Scissors)
  * **Paper beats Rock** (the Paper covers the Rock)

The **Winner** is the player whose choice beats the choice of his oponent. If both players choose the same option (e.g. "Paper"), the game outcome is **"Draw"**.

# Input and Output
The **Player** enters one of the following options:
  * **rock** or **r**
  * **paper** or **p**
  * **scissors** or **s**

The **Computer** chooses a **random option**, then reveals the **Winner**.

After every **Round**: **Display** current statistics and **Prompt** player to play again.

# Solution

Using Visual Studio with .NET Core 3.1 

<p align="center"> <img src="https://seeklogo.com/images/C/c-sharp-c-logo-02F17714BA-seeklogo.com.png" width="178" height="200"> <img src="https://1000logos.net/wp-content/uploads/2023/04/Visual-Studio-logo.png" width="355" height="200"> <img src="https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg" width="200" height="200"> <p>

# Algorithms Used:

- **variables (int; string):** Variables are used to store and manage data in your program. In this game, we use variables like `playerWins`, `computerWins`, and `playerMove` to keep track of game statistics and user input.

- **const string:** Constants are values that don't change throughout the program. We define constants like `Rock`, `Paper`, and `Scissors` to represent the player's and computer's choices.

- **loops (while; do while):** Loops allow us to repeat a block of code multiple times. The `while` loop is used to keep the game running until the player decides to quit. The `do while` loop ensures valid player input before proceeding.

- **conditional statements (if/else if/else; switch case;):** Conditional statements help us make decisions based on conditions. We use them to determine the winner of each round. For example, the `if/else if/else` statement compares player and computer choices to determine the winner, while the `switch case` statement generates the computer's move based on a random number.

- **comparison operators:** Comparison operators are used to compare values. In our game, we use them to check whether the player's choice beats the computer's choice. For instance, `(playerMove == Rock && computerMove == Scissors)` checks if the player chose Rock and the computer chose Scissors.

- **control flow statements (continue; break;):** Control flow statements manage the flow of execution in your program. We use `continue` to skip invalid inputs and allow the player to try again, and `break` to exit the game loop when the player chooses to quit.

- **classes (Program; Random):** Classes are used to define objects and their behavior. The `Program` class contains the game's main logic, while the `Random` class helps generate random computer moves.

- **methods (Main):** Methods are blocks of code that can be called to perform specific tasks. The `Main` method is the entry point of our program and contains the main game loop.

- **enumeration value (ConsoleColor):** Enumerations are user-defined types that consist of a set of named values. We use the `ConsoleColor` enumeration to change text colors in the console. For example, `Console.ForegroundColor = ConsoleColor.Cyan` changes the text color to cyan.

These programming concepts work together to create the functionality of the Rock-Paper-Scissors game. They enable the game to handle player input, generate random computer moves, determine winners, and display results.


## ⚡Source Code <a href="https://github.com/Peshote/Rock-Paper-Scissors-Game/blob/main/Project-Rock-Paper-Scissors/Rock-Paper-Scissors.cs"> Link </a>

## Screenshot Example

![image](https://github.com/Peshote/Rock-Paper-Scissors-Game/assets/124620028/b0a69e95-6ca6-4b42-a26c-6540e7bc1771)


## ⚡Live Demo

You can play the game directly in your Web Browser here:

<a href="https://replit.com/@Peshote/The-Rock-Paper-Scissors-Game#Main.cs" rel="Run"><img alt="Play Button" width="150px" src="https://user-images.githubusercontent.com/124620028/257953242-0f9cadaa-da43-430f-88cf-415f37b88ba4.png" />
