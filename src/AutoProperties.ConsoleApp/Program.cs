using AutoProperties.ConsoleApp.Entities;

Console.WriteLine("Digite seu primeiro nome:");
string firstName = Console.ReadLine();

Console.WriteLine("Digite seu último nome:");
string lastName = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
int age = int.Parse(Console.ReadLine());

var p = new Person(firstName, lastName, age);

Console.WriteLine($"Olá, {p.FirstName} {p.LastName}! Você tem {p.Age} anos.");