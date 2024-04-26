namespace Delegates.ConsoleApp.Services
{
    internal class CalculationService
    {
        public static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double GetMax(double number1, double number2)
        {
            return number1 > number2 ? number1 : number2;
        }
    }
}
