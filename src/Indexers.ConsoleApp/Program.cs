using Indexers.ConsoleApp.Entities;

var team = new Team();

// Using indexer
team[0] = "Lionel Messi";
team[1] = "Cristiano Ronaldo";
team[2] = "Neymar Júnior";

Console.WriteLine("O melhor jogador é: " + team[0]);
Console.WriteLine("O segundo melhor jogador é: " + team[1]);
Console.WriteLine("O terceiro melhor jogador é: " + team[2]);

// Not using indexer
//team[0].Players = "Lionel Messi";
//team[1].Players = "Cristiano Ronaldo";
//team[2].Players = "Neymar Júnior";

//Console.WriteLine("O melhor jogador é: " + team.Players[0]);
//Console.WriteLine("O segundo melhor jogador é: " + team.Players[1]);
//Console.WriteLine("O terceiro melhor jogador é: " + team.Players[2]);
