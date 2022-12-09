using BowlingScores;

namespace BowlingScoresUnitTests
{
    public class BowlingGameTests
    {
        [Fact]
        public void CanFindHighestScores()
        {
            var game = new BowlingGame();

            var expectedWinners = new List<BowlingGameRecord>
            {
                new BowlingGameRecord("Jeff", 300)
            };

            var expectedLosers = new List<BowlingGameRecord>
            {
                new BowlingGameRecord("Stacey", 200)
            };

            foreach (var p in expectedWinners)
            {
                game.AddAPlayerScore(p.player, p.score);
            }
            foreach (var p in expectedLosers)
            {
                game.AddAPlayerScore(p.player, p.score);
            }

            Assert.Equal(expectedWinners, game.HighScores());
            Assert.Equal(expectedLosers, game.LowScores());
        }
    }

    public class Issue98
    {
        [Fact]
        public void TheBadBehavior()
        {
            var game = new BowlingGame();

            game.HighScores();

            //Assert.Throws<InvalidOperationException>(() => game.HighScores());
        }

        [Fact]
        public void TheNewBehavior()
        {
            var game = new BowlingGame();

            var results = game.HighScores();

            Assert.Empty(results);
        }
    }
}