using PredicateDelegate.ConsoleApp.Entities;

var products = new List<Product>
{
    new("TV", 1250.0),
    new("Mouse", 100.0),
    new("Tablet", 250.0),
    new("HD Case", 50.0),
};

Predicate<Product> expensiveProductPredicate = IsExpensive;

products.RemoveAll(expensiveProductPredicate);

foreach (var product in products)
{
    Console.WriteLine(product);
}

static bool IsExpensive(Product product)
{
    return product.Price >= 1000.0;
}

// Predicate<T> delegate representa um método que recebe um objeto T e retorna um valor booleano