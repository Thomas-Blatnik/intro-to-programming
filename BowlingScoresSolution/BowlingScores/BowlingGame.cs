

namespace BowlingScores
{
    public class BowlingGame
    {
        private readonly List<BowlingGameRecord> _games = new();

        public void AddAPlayerScore(string name, int score)
        {
            var game = new BowlingGameRecord(name, score);
            _games.Add(game);
        }

        public List<BowlingGameRecord> HighScores()
        {
            if (_games.Count == 0) return _games;
            var highScore = _games.Select(g => g.score).Max();
            
            return _games.Where(g => g.score == highScore).ToList();
           
           
        }

        public List<BowlingGameRecord> LowScores()
        {
            if (_games.Count == 0) return _games;
            var lowScore = _games.Select(g => g.score).Min();

            return _games.Where(g => g.score == lowScore).ToList();
        }
    }
}
