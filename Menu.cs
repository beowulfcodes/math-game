namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new GameEngine();
        internal void ShowMenu(string? name)
        {
            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"Welcome aboard, {name}!");
                Console.WriteLine($@"What would you like to play today? Choose from the options below:
    V - View Score History
    A - Addition
    S - Subtraction
    M - Multiplication
    D - Division
    Q - Quit ");
                Console.WriteLine("");

                var gameSelected = Console.ReadLine();
                if (gameSelected != null)
                {
                    switch (gameSelected.ToLower().Trim())
                    {
                        case "v":
                            Helpers.GetScoreHistory();
                            break;
                        case "a":
                            gameEngine.AdditionGame("Addition Game");
                            break;
                        case "s":
                            gameEngine.SubtractionGame("Subtraction Game");
                            break;
                        case "m":
                            gameEngine.MultiplicationGame("Multiplication Game");
                            break;
                        case "d":
                            gameEngine.DivisionGame("Division Game");
                            break;
                        case "q":
                            Console.WriteLine("Goodbye!");
                            isGameOn = false;
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("No game selected."); // Handle the case where gameSelected is null
                }
            } while (isGameOn);
        }
    }
}
