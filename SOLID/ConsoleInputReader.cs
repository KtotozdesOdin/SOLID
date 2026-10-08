namespace SOLID
{
    public class ConsoleInputReader : IInputReader
    {
        public int ReadInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
