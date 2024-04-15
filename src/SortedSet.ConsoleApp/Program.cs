var evenNumbers = new SortedSet<int> { 0, 2, 4, 6, 8 };
var oddNumbers = new SortedSet<int> { 1, 3, 5, 7, 9 };

// União
IEnumerable<int> union = evenNumbers.Union(oddNumbers);
Console.Write("Union: ");
PrintCollection(union);
Console.WriteLine();

var set1 = new SortedSet<int> { 0, 1, 2, 3, 4 };
var set2 = new SortedSet<int> { 2, 5, 6, 8, 9 };

Console.Write("set1: ");
PrintCollection(set1);
Console.Write("set2: ");
PrintCollection(set2);
Console.WriteLine();

// Intersecção: número do primeiro conjunto(set1) que também está no segundo conjunto (set2)
IEnumerable<int> intersect = set1.Intersect(set2);
Console.Write("Numbers in set1 that are also in set2: ");
PrintCollection(intersect);
Console.WriteLine();

// Diferença: números em set1 que não estão em set2
Console.Write("Numbers in set1 that are not in set2: ");
IEnumerable<int> except1 = set1.Except(set2);
PrintCollection(except1);

static void PrintCollection<T> (IEnumerable<T> collection)
{
    List<T> list = collection.ToList();
    Console.Write("{ ");

    for (int i = 0; i < list.Count; i++)
    {
        Console.Write(list[i]);

        // Adiciona uma vírgula se não for o último elemento
        if (i < list.Count - 1)
        {
            Console.Write(", ");
        }
    }

    Console.WriteLine(" }");
}

// SortedSet<T> é uma coleção ordenada de itens distintos usadas para armazenar e manipular conjunto de dados não duplicados