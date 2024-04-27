namespace Delegates.ConsoleApp.Services
{
    internal delegate double BinaryOperation(double number1, double number2);

    internal class CalculationService
    {
        public static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double GetLarger(double number1, double number2)
        {
            return number1 > number2 ? number1 : number2;
        }
    }
}
