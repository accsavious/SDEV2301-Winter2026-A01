using System.Reflection;

namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetCircumference());
        }
        static double GetCircumference()
        {
            Console.Write("Input a radius, get a circumference:");
            bool success = double.TryParse(Console.ReadLine(), out double radius);
            return Math.PI * 2 * radius;
            
        }
    }
}
