using Tuples.ConsoleApp.DTOs;
using Tuples.ConsoleApp.Entities;

namespace Tuples.ConsoleApp.Extensions
{
    internal static class ProductDTOMappingExtension
    {
        public static IEnumerable<ProductDTO> ToProductDTOList(this IEnumerable<Product> products)
        {
            if (products == null || !products.Any())
            {
                return new List<ProductDTO>();
            }

            return products.Select(p => new ProductDTO(p.Id, p.Name, p.Price));
        }
    }
}
