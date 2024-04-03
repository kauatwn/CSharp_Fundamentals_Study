using Generics.ConsoleApp.Entities;
using Generics.ConsoleApp.Helpers;
using System.Globalization;

List<Product> list = [];

Console.Write("Enter the number for the quantity of products: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < number; i++)
{
    Console.Write($"Enter the #{i + 1} product name: ");
    string name = Console.ReadLine();

    Console.Write($"Enter the price for product '{name}': ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    var p = new Product(name, price);
    list.Add(p);
}

Product product = CalculationHelper.FindMaxValue(list);
Console.WriteLine(product);
