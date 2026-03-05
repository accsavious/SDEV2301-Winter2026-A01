namespace Lesson24Demo.Services
{
    public class MessageService
    {
        public string GetGreeting() => "Hello from service!";

        private static readonly string[] Quotes =
        {
            "The truth is rarely pure and never simple.",
            "We are all in the gutter, but some of us are looking at the stars.",
            "What is a cynic? Someone who knows the price of everything, and the value of nothing."
        };

        public string GetRandomQuote()
        {
            var random = new Random();
            return Quotes[random.Next(Quotes.Length)];
        }
    }
}
