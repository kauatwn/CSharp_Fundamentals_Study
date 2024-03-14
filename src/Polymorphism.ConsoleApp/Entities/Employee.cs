namespace Polymorphism.ConsoleApp.Entities
{
    internal class Employee(string name, int hours, double valuePerHour)
    {
        public string Name { get; set; } = name;
        public int Hours { get; set; } = hours;
        public double ValuePerHour { get; set; } = valuePerHour;

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
