using System.Globalization;

namespace PredicateDelegate.ConsoleApp.Entities
{
    internal class Product(string name, double price)
    {
        public string Name { get; set; } = name;
        public double Price { get; set; } = price;

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
