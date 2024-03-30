using ExtensionMethods.ConsoleApp.Entities;
using ExtensionMethods.ConsoleApp.Extensions;

var animal1 = new Dog()
{
    Name = "Bolinha",
    Age = 5,
    Breed = "Rottweiler",
    Strength = true
};

var animal2 = new Cat()
{
    Name = "Frajola",
    Age = 3,
    Breed = "Persian",
    Outgoing = true
};

// Downcasting implícito.
animal1.WriteAnimalInfo();
animal2.WriteAnimalInfo();