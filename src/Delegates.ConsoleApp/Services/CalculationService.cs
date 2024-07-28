namespace Delegates.ConsoleApp.Services
{
    internal delegate double ArithmeticOperationDelegate(double number1, double number2);

    internal class CalculationService
    {
        public static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }

        public static double GetLargerNumber(double number1, double number2)
        {
            return number1 > number2 ? number1 : number2;
        }
    }
}
