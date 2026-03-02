namespace Lesson24Demo.Services
{
    public class TipCalculatorService
    {
        public decimal CalculateTip(decimal billAmount, int tipPercentage)
        {
            return Math.Round(billAmount * (tipPercentage / 100m), 2);
        }

        public decimal CalculateTotal(decimal billAmount, int tipPercentage)
        {
            return billAmount + CalculateTip(billAmount, tipPercentage);
        }

        public decimal SplitTotal(decimal billAmount, int tipPercentage, int numberOfPeople)
        {
            return Math.Round(CalculateTotal(billAmount, tipPercentage) / numberOfPeople, 2);
        }
    }
}
