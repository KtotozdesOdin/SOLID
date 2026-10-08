namespace SOLID
{
    public class GuessNumberGame
    {
        private readonly GameSettings _gameSettings;
        private readonly INumberGenerator _numberGenerator;
        private readonly IInputReader _inputReader;
        private readonly IOutputWriter _outputWriter;

        public GuessNumberGame(GameSettings gameSettings,
                               INumberGenerator randomNumberGenerator,
                               IInputReader inputReader,
                               IOutputWriter outputWriter)
        {
            _gameSettings = gameSettings;
            _numberGenerator = randomNumberGenerator;
            _inputReader = inputReader;
            _outputWriter = outputWriter;
        }

        public void Run()
        {
            int minNumber = _gameSettings.MinNumber;
            int maxNumber = _gameSettings.MaxNumber;

            int randomNumber = _numberGenerator.Generate(minNumber, maxNumber);
            bool isWin = false;

            for (int i = 1; i <= _gameSettings.MaxAttempt; i++)
            {
                _outputWriter.Write($"Попытка {i}. Введите число:");

                var number = _inputReader.ReadInput();

                if (number == randomNumber)
                {
                    _outputWriter.Write("Вы выиграли");
                    isWin = true;
                    break;
                }
                else if (number < randomNumber)
                {
                    _outputWriter.Write("Ваше число меньше загаданного");
                }
                else if (number > randomNumber)
                {
                    _outputWriter.Write("Ваше число больше загаданного");
                }

            }

            if (!isWin)
            {
                _outputWriter.Write("Вы проиграли!");
            }

        }

    }
}
