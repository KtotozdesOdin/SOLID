namespace SOLID
{
    public class GameSettingsValidator
    {
        public void Validate(GameSettings settings)
        {
            if (settings.MinNumber >= settings.MaxNumber)
            {
                throw new ArgumentException("MinNumber должен быть меньше MaxNumber.");
            }

            if (settings.MaxAttempt <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(settings.MaxAttempt),
                    "Количество попыток должно быть больше нуля.");
            }

        }

    }
}
