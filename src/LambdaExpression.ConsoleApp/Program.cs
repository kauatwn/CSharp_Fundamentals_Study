using LambdaExpression.ConsoleApp.Entities;

var people = new List<Person>
{
    new() { Name = "Alice", Age = 30 },
    new() { Name = "Bob", Age = 20 },
    new() { Name = "Charlie", Age = 40 },
    new() { Name = "David", Age = 25 }
};

// Utilizando expressão lambda para filtrar pessoas com idade superior a 25 anos
IEnumerable<Person> filteredPeople = people.Where(p => p.Age > 25);

// Imprimindo os nomes das pessoas filtradas
foreach (var person in filteredPeople)
{
    Console.WriteLine(person.Name);
}
