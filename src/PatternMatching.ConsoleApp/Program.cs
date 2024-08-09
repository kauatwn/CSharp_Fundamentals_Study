using PatternMatching.ConsoleApp.Entities;
using PatternMatching.ConsoleApp.Services;

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

AnimalService.WriteAnimalInfo(animal1);
AnimalService.WriteAnimalInfo(animal2);
