namespace GetHashCodeAndEquals.ConsoleApp.Entities
{
    internal class Animal
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Breed { get; set; } = string.Empty;

        // Verifica se as raças são iguais
        public override bool Equals(object? obj)
        {
            return obj is Animal animal &&
                   Breed == animal.Breed;
        }

        public override int GetHashCode()
        {
            return Breed.GetHashCode();
        }
    }
}
