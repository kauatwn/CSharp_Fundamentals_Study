using MulticastDelegates.ConsoleApp.Services;

static void PerformOperations(BinaryOperation operation, double number1, double number2)
{
    Console.WriteLine("Performing operations:");
    operation.Invoke(number1, number2);
}

double number1 = 20.0;
double number2 = 10.0;

// Combining delegates (multicast delegates)
BinaryOperation operation = CalculationService.Sum;
operation += CalculationService.Subtract;
operation += CalculationService.Divide;
operation += CalculationService.GetLargerNumber;


// Delegate as variable
operation.Invoke(number1, number2);
Console.WriteLine();


// Delegate as argument
PerformOperations(operation, number1, number2);
