using System;

namespace RPSGame
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public string ChooseMove()
        {
            string move = string.Empty;
            try
            {
                Console.WriteLine("Choose your move (rock, paper, or scissors): ");
                move = Console.ReadLine().ToLower();
                while (Array.IndexOf(RPSGame.moves, move) == -1)
                {
                    Console.WriteLine("Invalid move. Please choose rock, paper, or scissors: ");
                    move = Console.ReadLine().ToLower();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return move;
        }
    }
}

