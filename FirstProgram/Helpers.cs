using FirstProgram.Models;

namespace FirstProgram
{
    internal class Helpers
    {
        static List<Game> games = new();

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Game History:");
            Console.WriteLine("----------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts.");
            }
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadLine();
        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }

        internal static int[] GetDivisionNumber()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please tell your name?");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.Write("Name can't be empty.");
                name = Console.ReadLine();  
            }
            return name;
        }
    }
}
