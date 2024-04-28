using FuncDelegate.ConsoleApp.Entities;

var products = new List<Product>
{
    new("TV", 1250.0),
    new("Mouse", 100.0),
    new("Tablet", 250.0),
    new("HD Case", 50.0),
};

Func<Product, string> productNameToUpperFunc = ProductNameToUpper;

List<string> productNamesInUpperCase = products.Select(productNameToUpperFunc).ToList();

foreach (var product in products)
{
    Console.WriteLine(product);
}

static string ProductNameToUpper(Product p)
{
    return p.Name.ToUpper();
}

// Func<T> delegate encapsula métodos que retornam valores TResult e pode receber até 16 parâmetros de entrada