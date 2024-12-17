HashSet<string> set =
[
    "TV",
    "Notebook",
    "Tablet"
];

Console.WriteLine(set.Contains("Computer"));

foreach (string item in set)
{
    Console.WriteLine(item);
}

// HashSet<T> é uma coleção não ordenada de itens distintos usadas para armazenar e manipular conjunto de dados não duplicados