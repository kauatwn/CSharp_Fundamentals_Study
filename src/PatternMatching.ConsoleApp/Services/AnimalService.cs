using PatternMatching.ConsoleApp.Entities;

namespace PatternMatching.ConsoleApp.Services
{
    internal class AnimalService
    {
        public static void WriteAnimalInfo(Animal animal)
        {
            // Downcasting implícito
            if (animal is Dog dog)
            {
                if (dog is { Age: >= 0, Name.Length: > 3, Breed.Length: > 3 })
                {
                    Console.WriteLine($"Cachorro: {dog.Name} - Idade: {dog.Age} - Raça: {dog.Breed}");
                }
            }

            // Downcasting implícito
            if (animal is Cat cat)
            {
                if (cat is { Age: >= 0, Name.Length: > 3, Breed.Length: > 3 })
                {
                    Console.WriteLine($"Gato: {cat.Name} - Idade: {cat.Age} - Raça: {cat.Breed}");
                }
            }
        }
    }
}
