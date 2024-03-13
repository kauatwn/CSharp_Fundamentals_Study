var list = new List<string> { "Maria", "Alex" };

/* Outra forma de criar lista
 * 
 * List<string> list = ["Maria", "Alex"];
 */

// Imprime todos os itens da lista
foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");

// Insere na segunda posição da lista
list.Insert(2, "Marco");

// Adiciona ao final da lista
list.Add("Anna");
foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");

// Obtém nomes com tamanho 5
var list2 = list.FindAll(item => item.Length == 5);
foreach (var name in list2)
{
    Console.WriteLine(name);
}