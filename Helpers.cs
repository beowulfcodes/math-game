using MathGame.Model;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> scoreHistory = new List<Game>();
        internal static void AddToScoreHistory(int gameScore, GameType gameSelected)
        {
            scoreHistory.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameSelected,
            });
        }
        internal static void GetScoreHistory()
        {
            Console.Clear();
            Console.WriteLine("Score History");
            Console.WriteLine("");

            foreach (var score in scoreHistory)
            {
                Console.WriteLine($"{score.Date} - {score.Type}: {score.Score}pt/s");
            }

            Console.WriteLine("");
            Console.WriteLine("Press enter to go back to main menu.");
            Console.ReadLine();
        }
        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer should be an integer!");
                result = Console.ReadLine();
            }

            return result;
        }
    }
}
