namespace ExtensionMethods.ConsoleApp.Entities
{
    internal abstract class Animal
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Breed { get; set; } = string.Empty;
    }
}
