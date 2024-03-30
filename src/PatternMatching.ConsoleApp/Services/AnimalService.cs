using PatternMatching.ConsoleApp.Entities;

namespace PatternMatching.ConsoleApp.Services
{
    internal class AnimalService
    {
        public static void WriteAnimalInfo(Animal animal)
        {
            if (animal is Dog dog)
            {
                Console.WriteLine($"Cachorro: {dog.Name} - Idade: {dog.Age} - Raça: {dog.Name}");
            }
            else if (animal is Cat cat)
            {
                Console.WriteLine($"Gato: {cat.Name} - Idade: {cat.Age} - Raça: {cat.Name}");
            }
        }
    }
}