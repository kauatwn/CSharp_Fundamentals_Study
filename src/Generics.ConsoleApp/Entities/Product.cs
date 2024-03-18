using System.Globalization;

namespace Generics.ConsoleApp.Entities
{
    internal class Product(string name, double price) : IComparable
    {
        public string Name { get; set; } = name;
        public double Price { get; set; } = price;

        public int CompareTo(object? obj)
        {
            // Realizando o casting.
            var other = obj as Product; // var other = (Product) obj;

            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"Most expensive product: {Name} - Price: {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
