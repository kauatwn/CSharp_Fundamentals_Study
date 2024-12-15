List<string> list = ["Maria", "Alex"];

// Imprime todos os itens da lista
foreach (string item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("----------");

// Insere na segunda posição da lista
list.Insert(2, "Marco");

// Adiciona ao final da lista
list.Add("Anna");
foreach (string item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("----------");

// Obtém nomes com tamanho 5
List<string> list2 = list.FindAll(item => item.Length == 5);
foreach (string name in list2)
{
    Console.WriteLine(name);
}