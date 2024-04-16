var dictionary = new Dictionary<int, string>
{
    {1,"Banana"},
    {3, "Manga"},
    {2, "Laranja"},
    {4, "Abacate"},
    {5,"Maça"}
};

foreach (var item in dictionary)
{
    Console.WriteLine("Chave: {0}, valor: {1}", item.Key, item.Value);
}
Console.WriteLine();

// Dictionary<TKey, TValue> é uma coleção genérica que armazena pares chave-valor sem ordem específica.