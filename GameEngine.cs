namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 10);
                secondNumber = random.Next(1, 10);

                Console.WriteLine($"{firstNumber} + {secondNumber} = ");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);


                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer is correct!");
                    score++;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect.");
                    Console.WriteLine("");
                }

            }


            Helpers.AddToScoreHistory(score, Model.GameType.Addition);

            Console.WriteLine(@$"Gameover! Your final score is {score}/5. Press enter to go back to the main menu.");
            Console.ReadLine();
        }
        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 10);
                secondNumber = random.Next(1, 10);

                Console.WriteLine($"{firstNumber} - {secondNumber} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer is correct!");
                    score++;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect.");
                    Console.WriteLine("");
                }
            }

            Helpers.AddToScoreHistory(score, Model.GameType.Subtraction);

            Console.WriteLine(@$"Gameover! Your final score is {score}/5. Press enter to go back to the main menu.");
            Console.ReadLine();
        }
        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 10);
                secondNumber = random.Next(1, 10);

                Console.WriteLine($"{firstNumber} * {secondNumber} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer is correct!");
                    score++;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect.");
                    Console.WriteLine("");
                }
            }

            Helpers.AddToScoreHistory(score, Model.GameType.Multiplication);

            Console.WriteLine(@$"Gameover! Your final score is {score}/5. Press enter to go back to the main menu.");
            Console.ReadLine();
        }
        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 10);

                while (firstNumber % secondNumber != 0)
                {
                    firstNumber = random.Next(1, 99);
                    secondNumber = random.Next(1, 10);
                }

                Console.WriteLine($"{firstNumber} / {secondNumber} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer is correct!");
                    score++;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect.");
                    Console.WriteLine("");
                }
            }

            Helpers.AddToScoreHistory(score, Model.GameType.Division);

            Console.WriteLine(@$"Gameover! Your final score is {score}/5. Press enter to go back to the main menu.");
            Console.ReadLine();
        }

    }
}
