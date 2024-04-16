var sortedDictionary = new SortedDictionary<int, string>
{
    { 3, "Manga" },
    { 1, "Banana" },
    { 2, "Laranja" }
};

foreach (var item in sortedDictionary)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// SortedDictionary<TKey, TValue> é uma coleção genérica que armazena pares chave-valor ordenados com base na chave.