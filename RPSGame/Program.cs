using System;

namespace RPSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Player player = new Player("Player");
                Player ai = new Player("AI");

                // Uncomment one of the lines below to choose whether to use cheat mode or not
                //RPSGame.ManageGameFlow(player, ai, useCheatMode: false); // Normal mode
                RPSGame.ManageGameFlow(player, ai, useCheatMode: true); // Cheat mode

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
