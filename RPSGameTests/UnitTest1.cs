using Xunit;
using RPSGame;

namespace RPSGameTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("rock", "scissors", "Player")]
        [InlineData("rock", "paper", "AI")]
        [InlineData("scissors", "paper", "Player")]
        [InlineData("scissors", "rock", "AI")]
        [InlineData("paper", "rock", "Player")]
        [InlineData("paper", "scissors", "AI")]
        [InlineData("rock", "rock", "Tie")]
        [InlineData("paper", "paper", "Tie")]
        [InlineData("scissors", "scissors", "Tie")]
        public void GetWinner_Test(string playerMove, string aiMove, string expectedWinner)
        {
            string actualWinner = RPSGame.RPSGame.GetWinner(playerMove, aiMove);
            Assert.Equal(expectedWinner, actualWinner);
        }

        [Theory]
        [InlineData("rock", "scissors", 1, 0)]
        [InlineData("rock", "paper", 0, 1)]
        [InlineData("scissors", "paper", 1, 0)]
        [InlineData("scissors", "rock", 0, 1)]
        [InlineData("paper", "rock", 1, 0)]
        [InlineData("paper", "scissors", 0, 1)]
        [InlineData("rock", "rock", 0, 0)]
        [InlineData("paper", "paper", 0, 0)]
        [InlineData("scissors", "scissors", 0, 0)]
        public void UpdateScores_Test(string playerMove, string aiMove, int expectedPlayerScoreIncrement, int expectedAiScoreIncrement)
        {
            // Arrange
            Player player = new Player("Player");
            Player ai = new Player("AI");
            int initialPlayerScore = player.Score;
            int initialAiScore = ai.Score;

            // Act
            string winner = RPSGame.RPSGame.GetWinner(playerMove, aiMove);
            if (winner == "Player")
            {
                player.Score++;
            }
            else if (winner == "AI")
            {
                ai.Score++;
            }

            // Assert
            Assert.Equal(initialPlayerScore + expectedPlayerScoreIncrement, player.Score);
            Assert.Equal(initialAiScore + expectedAiScoreIncrement, ai.Score);
        }
    }
}
