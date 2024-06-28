namespace Tuples.ConsoleApp.DTOs
{
    internal record PaginationMetadataDTO(int TotalCount, int PageNumber, int PageSize)
    {
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public bool HasPreviousPage => PageSize > 1;
        public bool HasNextPage => PageSize < TotalPages;
    }
}
