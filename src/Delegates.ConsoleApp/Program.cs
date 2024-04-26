using Delegates.ConsoleApp.Services;

double value1 = 20.0;
double value2 = 20.0;

ArithmeticOperation operation = CalculationService.Sum;

double result =  operation(value1, value2);
Console.WriteLine(result);

delegate double ArithmeticOperation(double number1, double number2);