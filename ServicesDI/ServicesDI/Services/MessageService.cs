namespace ServicesDI.Services
{
    public class MessageService
    {
        public string GetGreeting() => "Hello from Message Service, get your fortune:";

        private static readonly string[] Quotes =
        {
            "Bad luck: Run over by truck",
            "Good luck: You will get rich",
            "Medium luck: Breakup with bad friend or lover",
        };
        public string GetRandomQuote()
        {
            var rand = new Random();
            return Quotes[rand.Next(Quotes.Length)];
        }
    }
}
