using System.Text.Encodings.Web;
using System.Text.Json;
using Tuples.ConsoleApp.Entities;
using Tuples.ConsoleApp.Pagination.Filters;
using Tuples.ConsoleApp.Services;

var productService = new ProductService();

var source = new PaginationFilter<Product>
{
    PageNumber = 1,
    PageSize = 5
};

var result = productService.GetPagedProducts(source);

// Serializar os resultados para JSON
var productsJson = JsonSerializer.Serialize(result.Products, new JsonSerializerOptions()
{
    WriteIndented = true,
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
});

var metadataJson = JsonSerializer.Serialize(result.Metadata);

// Exibir JSON no console
Console.WriteLine("Produtos:");
Console.WriteLine(productsJson);

Console.WriteLine("\nMetadados de Paginação:");
Console.WriteLine(metadataJson);
