using Array.ConsoleApp.Entities;

var random = new Random();

Console.Write("Array de tipo valor: [ ");

// Define o tamanho do array
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    // Insere valores aleatórios nos índices do array
    array[i] = random.Next(1, 101);
    Console.Write(array[i]);

    // Adiciona uma vírgula se não for o último elemento
    if (i < array.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine(" ]");

Console.Write("Array de tipo referência: [ ");
var products = new Product[5];
for (int i = 0; i < products.Length; i++)
{
    int price = random.Next(1, 101);
    // Cria uma instância e já atribui o valor da variável ao atributo da classe
    products[i] = new Product { Price = price };
    Console.Write(products[i].Price);
    if (i < array.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine(" ]");