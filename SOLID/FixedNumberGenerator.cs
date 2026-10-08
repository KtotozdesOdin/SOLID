namespace SOLID
{
    public class FixedNumberGenerator : INumberGenerator
    {
        private readonly int _number;
        public FixedNumberGenerator(int number)
        {
            _number = number;
        }
        public int Generate(int min, int max)
        {
            if (min <= _number && _number <= max)
            {
                return _number;
            }

            throw new ArgumentOutOfRangeException(nameof(_number),
                $"Число {_number} должно быть в диапазоне от {min} до {max}.");
        }
    }
}
