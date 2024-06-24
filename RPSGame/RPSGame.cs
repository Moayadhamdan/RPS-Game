using System;

namespace RPSGame
{
    public class RPSGame
    {
        public static string[] moves = { "rock", "paper", "scissors" };

        public static string GetWinner(string playerMove, string aiMove)
        {
            if (playerMove == aiMove)
                return "Tie";

            if ((playerMove == "rock" && aiMove == "scissors") ||
                (playerMove == "paper" && aiMove == "rock") ||
                (playerMove == "scissors" && aiMove == "paper"))
                return "Player";

            return "AI";
        }

        public static string GetAIMove()
        {
            Random rnd = new Random();
            int index = rnd.Next(moves.Length);
            return moves[index];
        }

        // Cheat method for AI (Hard Mode)
        public static string GetAICheatMove(string playerMove)
        {
            switch (playerMove)
            {
                case "rock":
                    return "paper"; // AI chooses paper to beat rock
                case "paper":
                    return "scissors"; // AI chooses scissors to beat paper
                case "scissors":
                    return "rock"; // AI chooses rock to beat scissors
                default:
                    throw new ArgumentException("Invalid player move");
            }
        }

        public static void PlayRound(Player player, Player ai, bool useCheatMode)
        {
            string playerMove = player.ChooseMove();

            string aiMove;
            if (useCheatMode)
            {
                aiMove = GetAICheatMove(playerMove);
                Console.WriteLine("AI (Cheat Mode) chose: " + aiMove);
            }
            else
            {
                aiMove = GetAIMove();
                Console.WriteLine("AI chose: " + aiMove);
            }

            string winner = GetWinner(playerMove, aiMove);
            if (winner == "Player")
            {
                player.Score++;
                Console.WriteLine("You win this round!");
            }
            else if (winner == "AI")
            {
                ai.Score++;
                Console.WriteLine("AI wins this round!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }

            DisplayScores(player, ai);
        }

        public static void DisplayScores(Player player, Player ai)
        {
            Console.WriteLine($"\nScores:\n{player.Name}: {player.Score}\n{ai.Name}: {ai.Score}");
        }

        public static void ManageGameFlow(Player player, Player ai, bool useCheatMode)
        {
            int roundNumber = 1;
            while (player.Score < 3 && ai.Score < 3)
            {
                Console.WriteLine($"Round {roundNumber}:");
                PlayRound(player, ai, useCheatMode);
                roundNumber++;
            }

            if (player.Score > ai.Score)
            {
                Console.WriteLine("\nCongratulations! You won the game!");
            }
            else
            {
                Console.WriteLine("\nAI won the game! Better luck next time!");
            }
        }
    }
}

