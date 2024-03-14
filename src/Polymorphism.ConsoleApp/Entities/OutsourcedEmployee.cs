namespace Polymorphism.ConsoleApp.Entities
{
    internal class OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : Employee(name, hours, valuePerHour)
    {
        public double AdditonalCharge { get; set; } = additionalCharge;

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditonalCharge;
        }
    }
}
