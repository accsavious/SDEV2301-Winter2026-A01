namespace Lesson24Demo.Services
{
    public class ColorService
    {
        private static readonly string[] Colors =
        {
            "#FF6B6B", "#6BCB77", "#4D96FF", "#FFD93D",
            "#C77DFF", "#FF922B", "#20C997", "#F06595"
        };

        public string GetRandomColor()
        {
            var random = new Random();
            return Colors[random.Next(Colors.Length)];
        }
    }
}
