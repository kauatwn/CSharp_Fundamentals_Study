using SwitchExpression.ConsoleApp;

Console.WriteLine("Choose a drink type:\n");
Console.WriteLine("1. Coffee");
Console.WriteLine("2. Tea");
Console.WriteLine("3. Juice");
Console.WriteLine("4. Soda\n");

int option = int.Parse(Console.ReadLine());
Console.WriteLine();

DrinkType chosenDrink = (DrinkType)option;

decimal price = chosenDrink switch
{
    DrinkType.Coffee => 3.50m,
    DrinkType.Tea => 2.00m,
    DrinkType.Juice => 5.00m,
    DrinkType.Soda => 4.00m,
    _ => throw new ArgumentException("Invalid option.")
};

Console.WriteLine($"The price of the chosen drink is: $ {price}");
