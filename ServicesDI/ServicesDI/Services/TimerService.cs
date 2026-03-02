namespace ServicesDI.Services
{
    public class TimerService
    {
        public string GetCurrentTime => DateTime.Now.ToString("T");
    }
}
