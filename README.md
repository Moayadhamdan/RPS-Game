# Rock, Paper, Scissors Game

This console application simulates the classic game of Rock, Paper, Scissors where a player competes against an AI opponent.

## Project Structure

The project is structured as follows:

- **RPSGame**: Contains the main classes and logic for the game.
  - `Program.cs`: Entry point of the application.
  - `Player.cs`: Defines the Player class with properties and methods related to the player.
  - `RPSGame.cs`: Manages the game logic including move comparisons, determining winners, and managing game flow.
- **RPSGameTests**: Contains Xunit test cases to verify the game logic.
  - `UnitTest1.cs`: Xunit test cases for testing the game logic including determining winners and updating scores.
- `README.md`: This file, providing an overview of the project.

## Getting Started

### Prerequisites

- Visual Studio 2022 (or any compatible IDE with C# support)
- .NET SDK

### Running the Application

1. Clone the repository to your local machine.
2. Open the solution (`RPSGame.sln`) in Visual Studio.
3. Set `RPSGame` project as the startup project.
4. Build and run the application.

### Game Rules

- Each player (you vs AI) chooses either rock, paper, or scissors.
- The winner of each round is determined based on the following rules:
  - Rock beats Scissors
  - Scissors beats Paper
  - Paper beats Rock
- The game continues for 3 rounds.
- The player with the highest score after 3 rounds wins.

### Running Unit Tests

1. Ensure the solution is open in Visual Studio.
2. Build the solution.
3. In Visual Studio, go to Test Explorer.
4. Run all tests to verify the game logic.

## Additional Notes

- The application includes a cheat mode for the AI which predicts the player's move to gain an unfair advantage. This is for demonstration purposes only.
- Exception handling is implemented to manage any unexpected errors during gameplay.
- Input validation ensures that players can only choose valid moves (rock, paper, or scissors).

Enjoy playing Rock, Paper, Scissors against the AI!

