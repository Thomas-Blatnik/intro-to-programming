using BowlingScores;

namespace BowlingScoresUnitTests
{
    public class BowlingGameTests
    {
        [Fact]
        public void CanFindHighestScores()
        {
            var game = new BowlingGame();

            game.AddAPlayerScore("Jeff", 300);
            game.AddAPlayerScore("Stacey", 200);

            var expectedWinners = new List<BowlingGameRecord>
            {
                new BowlingGameRecord("Jeff", 300)
            };

            var expectedLosers = new List<BowlingGameRecord>
            {
                new BowlingGameRecord("Stacey", 200)
            };

            foreach(var p in expectedWinners)
            {
                game.AddAPlayerScore(p.player, p.score);
            }
            foreach(var p in expectedLosers)
            {
                game.AddAPlayerScore(p.player, p.score);
            }

            Assert.Equal(expectedWinners, game.HighScores());
            Assert.Equal(expectedLosers, game.LowScores());
        }
    }
}