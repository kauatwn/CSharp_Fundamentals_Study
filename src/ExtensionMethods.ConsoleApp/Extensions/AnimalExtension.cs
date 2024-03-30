using ExtensionMethods.ConsoleApp.Entities;

namespace ExtensionMethods.ConsoleApp.Extensions
{
    internal static class AnimalExtension
    {
        public static void WriteAnimalInfo(this Animal animal)
        {
            if (animal is Dog dog)
            {
                Console.WriteLine($"Cachorro: {dog.Name} - Idade: {dog.Age} - Raça: {dog.Breed}");
            }
            else if (animal is Cat cat)
            {
                Console.WriteLine($"Gato: {cat.Name} - Idade: {cat.Age} - Raça: {cat.Outgoing}");
            }
        }
    }
}
