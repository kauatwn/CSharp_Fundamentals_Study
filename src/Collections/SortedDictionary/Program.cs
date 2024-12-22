SortedDictionary<int, string> sortedDictionary = new()
{
    { 3, "Manga" },
    { 1, "Banana" },
    { 2, "Laranja" }
};

foreach (KeyValuePair<int, string> item in sortedDictionary)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// SortedDictionary<TKey, TValue> é uma coleção genérica que armazena pares chave-valor ordenados com base na chave.