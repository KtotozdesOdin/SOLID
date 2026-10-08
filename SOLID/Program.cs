namespace SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameSettings settings = new GameSettings
            {
                MaxAttempt = 3,
                MinNumber = 1,
                MaxNumber = 100
            };

            //INumberGenerator numberGenerator = new RandomNumberGenerator();
            INumberGenerator numberGenerator = new FixedNumberGenerator(150);
            IInputReader inputReader = new ConsoleInputReader();
            IOutputWriter writer = new ConsoleOutputWriter();

            var game = new GuessNumberGame(settings,
                                           numberGenerator,
                                           inputReader,
                                           writer);

            game.Run();
        }
    }
}
