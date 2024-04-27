using Delegates.ConsoleApp.Services;

static double PerformOperation(BinaryOperation binaryOperation, double number1, double number2)
{
    return binaryOperation(number1, number2);
}

double number1 = 20.0;
double number2 = 10.0;

// Delegates as arguments
double sumResult = PerformOperation(CalculationService.Sum, number1, number2);
Console.WriteLine($"{number1} plus {number2} equals {sumResult}.");


// Delegate as variable
BinaryOperation operation = CalculationService.Subtract;
double subtractionResult = operation(number1, number2);
Console.WriteLine($"{number1} minus {number2} equals {subtractionResult}.");


// Lambda expression as a delegate
double largerstNumber = PerformOperation((n1, n2) => CalculationService.GetLargerNumber(n1, n2), number1, number2);
Console.WriteLine($"The largerst number between {number1} and {number2} is {largerstNumber}.");


// Anonymous function with delegate
double divisionResult = PerformOperation(delegate (double n1, double n2)
{
    return CalculationService.Divide(n1, n2);
}, number1, number2);
Console.WriteLine($"{number1} divided by {number2} equals {divisionResult}.");
