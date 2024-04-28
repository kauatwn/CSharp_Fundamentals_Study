// Specify the data source
int[] numbers = [2, 3, 4, 5];

// Define the query expression using method syntax
IEnumerable<int> resultMethod = numbers.Where(number => number % 2 == 0).Select(number => number * 10);

// Define the query expression using query syntax
var resultQuery = from number in numbers
                  where (number % 2) == 0
                  select number * 10;

// Execute the query using method syntax
Console.WriteLine("Method Syntax:");
foreach (int number in resultMethod)
{
    Console.WriteLine(number);
}

Console.WriteLine();

// Execute the query using query syntax
Console.WriteLine("Query Syntax:");
foreach (int number in resultQuery)
{
    Console.WriteLine(number);
}

// LINQ (Language Integrated Query) permite consultar e manipular dados de maneira declarativa usando sintaxe semelhante a SQL