using System.Globalization;

namespace OverrideModifier.ConsoleApp.Entities
{
    internal class Product
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double TotalValueInStock()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Name}, $ {Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Quantity} unidades, Total: $" +
                $"{TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
