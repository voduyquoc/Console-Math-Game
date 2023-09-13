namespace FirstProgram
{
    internal class Menu
    {
        GameEngine gameEngine = new();

        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself");
            Console.WriteLine("Press any key to show menu.");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"
What game you would like to play today? Choose from the below options:
V - View previous games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program.");
                Console.WriteLine("----------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game.");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game.");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Mutiplication game.");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game.");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye.");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            } while (isGameOn);
        }
    }
}
