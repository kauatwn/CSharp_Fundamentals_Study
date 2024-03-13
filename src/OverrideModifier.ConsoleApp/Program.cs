using OverrideModifier.ConsoleApp.Entities;

var p = new Product();

Console.WriteLine("Escreva os dados do produto:");
Console.Write("Nome: ");
p.Name = Console.ReadLine();
Console.Write("Preço: ");
p.Price = double.Parse(Console.ReadLine());
Console.Write("Quantidade em estoque: ");
p.Quantity = int.Parse(Console.ReadLine());

Console.WriteLine(p);