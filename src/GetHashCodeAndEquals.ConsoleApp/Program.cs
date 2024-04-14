using GetHashCodeAndEquals.ConsoleApp.Entities;

var animal1 = new Animal { Name = "Rex", Age = 5, Breed = "Labrador" };
var animal2 = new Animal { Name = "Whiskers", Age = 3, Breed = "Siamese" };
var animal3 = new Animal { Name = "Buddy", Age = 4, Breed = "Golden Retriever" };
var animal4 = new Animal { Name = "Mittens", Age = 2, Breed = "Persian" };
var animal5 = new Animal { Name = "Spot", Age = 6, Breed = "Dalmatian" };
var animal6 = new Animal { Name = "Bob", Age = 2, Breed = "Labrador" };

var animals = new List<Animal> { animal1, animal2, animal3, animal4, animal5, animal6 };

foreach (var animal in animals)
{
    Console.WriteLine($"Nome: {animal.Name}, Idade: {animal.Age}, Raça: {animal.Breed}");
}
Console.WriteLine();

// Comparando animal1 com animal6 usando GetHashCode e Equals
Console.WriteLine($"Comparando se raça de animal1 é igual ao de animal6: {animal1.Equals(animal6)}");
Console.WriteLine($"HashCode de animal1: {animal1.GetHashCode()}");
Console.WriteLine($"HashCode de animal6: {animal6.GetHashCode()}");

// O método GetHashCode é especialmente útil em cenários onde desejamos realizar uma comparação rápida de objetos.
// É utilizado, geralmente, para otimizar a busca em estruturas de dados como HashSet, Dictionary, entre outros.