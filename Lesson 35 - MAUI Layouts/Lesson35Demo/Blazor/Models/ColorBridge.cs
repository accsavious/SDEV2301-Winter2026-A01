namespace Lesson35Demo.Models
{
    public class ColorBridge
    {
        public static ColorBridge Instance { get; } = new ColorBridge();

        // Event raised whenever MAUI has a new confirmation result.
        public event Action? ColorChanged;

        public void ResetColors()
        {
            ColorChanged?.Invoke();
        }
    }
}
