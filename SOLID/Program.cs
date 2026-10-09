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

            var validation = new GameSettingsValidator();
            validation.Validate(settings);

            //INumberGenerator numberGenerator = new RandomNumberGenerator();
            INumberGenerator numberGenerator = new FixedNumberGenerator(42);
            IOutputWriter writer = new ConsoleOutputWriter();
            IInputReader inputReader = new ConsoleInputReader(writer);

            var game = new GuessNumberGame(settings,
                                           numberGenerator,
                                           inputReader,
                                           writer);

            game.Run();
        }
    }
}
