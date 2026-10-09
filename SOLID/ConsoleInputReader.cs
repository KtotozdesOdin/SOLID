namespace SOLID
{
    public class ConsoleInputReader : IInputReader
    {
        private readonly IOutputWriter _writer;

        public ConsoleInputReader(IOutputWriter writer)
        {
            _writer = writer;
        }
        public int ReadInput()
        {
            bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            while (!isParsed)
            {
                _writer.Write("Некорректный ввод. Введите целое число:");

                isParsed = int.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }
    }
}
