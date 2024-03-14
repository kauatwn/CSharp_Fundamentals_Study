using System.Globalization;

namespace Interface.ConsoleApp.Entities
{
    internal class Invoice(double basicPayment, double tax)
    {
        public double BasicPayment { get; set; } = basicPayment;
        public double Tax { get; set; } = tax;

        // Getter property
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Total payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
