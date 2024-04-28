using ActionDelegate.ConsoleApp.Entities;

var products = new List<Product>
{
    new("TV", 1250.0),
    new("Mouse", 100.0),
    new("Tablet", 250.0),
    new("HD Case", 50.0),
};

Action<Product> UpdateProductPriceAction = UpdateProductPrice;

products.ForEach(UpdateProductPriceAction);

foreach (var product in products)
{
    Console.WriteLine(product);
}

static void UpdateProductPrice(Product p)
{
    p.Price += p.Price * 0.1;
}

// Action<T> delegate encapsula métodos que não retornam valores e pode receber até 16 parâmetros de entrada