// O polimorfismo é o princípio que permite que diferentes classes derivadas de uma mesma superclasse invoquem métodos com a mesma assinatura,
// mas com comportamentos distintos e especializados para cada classe derivada.
// Já utilizamos polimorfismo em 'Inheritance.ConsoleApp'.

using Polymorphism.ConsoleApp.Entities;
using System.Globalization;

List<Employee> employees = [];

Console.Write("Enter the quantity of employees: ");
int quantityOfEmployees = int.Parse(Console.ReadLine());

for (int i = 0; i < quantityOfEmployees; i++)
{
    Console.WriteLine($"\nEmployee #{i + 1} data: ");
    Console.Write("Outsourced (y/n)? ");
    char c = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (c == 'y')
    {
        Console.Write("Additional Charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else
    {
        employees.Add(new Employee(name, hours, valuePerHour));
    }

}
Console.WriteLine("\nPayments:");
foreach (Employee employee in employees)
{
    Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}