using System.Globalization;

namespace Generics.ConsoleApp.Entities
{
    internal class Product(string name, double price) : IComparable<Product>
    {
        public string Name { get; set; } = name;
        public double Price { get; set; } = price;

        public int CompareTo(Product? other)
        {
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"Most expensive product: {Name} - Price: {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
