// Matriz bidimensional (row and column) com valores declarados
int[,] matrix = new int[3, 4]
{
    { 10, 8, 15, 12 },
    { 21, 11, 23, 8 },
    { 14, 5, 13, 19 }
};

Console.WriteLine("Two-dimensional matrix:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write("[ ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);

        // Adiciona uma vírgula se não for o último elemento
        if (j < matrix.GetLength(1) - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine(" ]");
}
Console.WriteLine();

int num = 8;
Console.WriteLine(num);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == num)
        {
            Console.WriteLine($"Position: [{i}, {j}]");

            // Verifica se não é o primeiro elemento
            if (j > 0)
            {
                Console.WriteLine($"Number to the left: {matrix[i, j - 1]}");
            }

            // Verifica se não for o último elemento
            if (j < matrix.GetLength(1) - 1)
            {
                Console.WriteLine($"Number to the right: {matrix[i, j + 1]}");
            }

            // Verifica se não é o primeiro elemento da primeira linha
            if (i > 0)
            {
                Console.WriteLine($"Number above: {matrix[i - 1, j]}");
            }

            // Verifica se não é o último elemento da última linha
            if (i < matrix.GetLength(0) - 1)
            {
                Console.WriteLine($"Number below: {matrix[i + 1, j]}");
            }
            Console.WriteLine();
        }
    }
}