namespace MulticastDelegates.ConsoleApp.Services
{
    internal delegate void BinaryOperation(double number1, double number2);

    internal class CalculationService
    {
        public static void Sum(double number1, double number2)
        {
            double result = number1 + number2;
            Console.WriteLine($"{number1} plus {number2} equals {result}.");
        }

        public static void Subtract(double number1, double number2)
        {
            double result = number1 - number2;
            Console.WriteLine($"{number1} minus {number2} equals {result}.");
        }

        public static void Divide(double number1, double number2)
        {
            double result = number1 / number2;
            Console.WriteLine($"{number1} divided by {number2} equals {result}.");
        }

        public static void GetLargerNumber(double number1, double number2)
        {
            double result = number1 > number2 ? number1 : number2;
            Console.WriteLine($"The largerst number between {number1} and {number2} is {result}.");
        }
    }
}
