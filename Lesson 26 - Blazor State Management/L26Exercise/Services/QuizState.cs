namespace L26Exercise.Services
{
    public class QuizState
    {
        public int Score { get; set; } = 0;
        public int TotalAnswered { get; set; } = 0;
        
        public void RecordAnswer(bool isCorrect)
        {
            TotalAnswered++;
            if (isCorrect) Score++;
        }

        public void Reset()
        {
            Score = 0;
            TotalAnswered =  0;
        }
    }
}
