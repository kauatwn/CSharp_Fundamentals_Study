using ParameterModifiers.ConsoleApp.Entities;

int sumResult = Calculator.Sum(5, 5);
Console.WriteLine(sumResult);

int value = 5;

// Com o ref, o valor é atribuído à mesma variável como referência
Calculator.Triple(ref value);
Console.WriteLine($"O valor triplicado é: {value}");

double dividend = 10;
double divisor = 2;
double divisionResult;
double remainder;

Calculator.Divide(dividend, divisor, out divisionResult, out remainder);
Console.WriteLine($"{dividend} dividido por {divisor} é igual a {divisionResult}");
Console.WriteLine($"Resto da divisão: {remainder}");