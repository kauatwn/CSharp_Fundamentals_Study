using Tuples.ConsoleApp.DTOs;
using Tuples.ConsoleApp.Entities;
using Tuples.ConsoleApp.Extensions;
using Tuples.ConsoleApp.Pagination.Filters;

namespace Tuples.ConsoleApp.Services
{
    internal class ProductService
    {
        public (IEnumerable<ProductDTO> Products, PaginationMetadataDTO Metadata) GetPagedProducts(PaginationFilter<Product> source)
        {
            // Simulação de dados de produtos
            IQueryable<Product> products = new List<Product>
            {
                new() { Id = 1, Name = "Feijoada Completa", Description = "Prato tradicional brasileiro com feijão preto, carne de porco, linguiça, arroz, couve e laranja", Price = 25.00m, Stock = 20 },
                new() { Id = 2, Name = "Picadinho de Carne", Description = "Carne bovina cortada em cubos e cozida com legumes, servida com arroz e farofa", Price = 22.50m, Stock = 18 },
                new() { Id = 3, Name = "Salada Caesar com Frango Grelhado", Description = "Salada Caesar clássica com alface, croutons, queijo parmesão, molho Caesar e peito de frango grelhado", Price = 18.00m, Stock = 22 },
                new() { Id = 4, Name = "Macarrão à Bolonhesa", Description = "Macarrão penne servido com molho de carne moída e queijo parmesão ralado", Price = 20.00m, Stock = 25 },
                new() { Id = 5, Name = "Risoto de Frutos do Mar", Description = "Risoto cremoso com frutos do mar, como camarões, lulas e vieiras", Price = 28.00m, Stock = 15 },
                new() { Id = 6, Name = "Lombo de Porco Assado", Description = "Lombo de porco assado lentamente no forno com ervas e temperos", Price = 24.00m, Stock = 20 },
                new() { Id = 7, Name = "Nhoque ao Molho Pesto", Description = "Nhoque de batata servido com molho pesto de manjericão fresco e queijo parmesão", Price = 21.50m, Stock = 18 },
                new() { Id = 8, Name = "Frango à Parmegiana", Description = "Peito de frango empanado e frito, coberto com molho de tomate e queijo derretido, servido com espaguete", Price = 23.50m, Stock = 20 },
                new() { Id = 9, Name = "Peixe Grelhado com Legumes", Description = "Filé de peixe grelhado servido com legumes grelhados e arroz branco", Price = 22.00m, Stock = 20 },
                new() { Id = 10, Name = "Lasanha de Frango e Espinafre", Description = "Lasanha com camadas de massa, frango desfiado, molho branco, espinafre e queijo", Price = 20.00m, Stock = 18 }
            }.AsQueryable();

            IQueryable<Product> pagedProducts = source.HandleFilter(products);

            int totalCount = products.Count();
            var metadataDto = new PaginationMetadataDTO(totalCount, source.PageNumber, source.PageSize);

            IEnumerable<ProductDTO> pagedProductsDto = ProductDTOMappingExtension.ToProductDTOList(pagedProducts);

            return (pagedProductsDto, metadataDto);
        }
    }
}
