using System.ComponentModel.DataAnnotations;

namespace api.Helpers
{
    public class Query
    {
        public string? Symbol { get; set; } = null;

        public string? CompanyName { get; set; } = null;

        public string? SortBy { get; set; } = null;

        public bool IsDescending { get; set; } = false;

        [Range(1, int.MaxValue, ErrorMessage = "Page number must be a natural number")]
        public int PageNumber { get; set; } = 1;

        [Range(1, 50, ErrorMessage = "Page size must be between 1 and 50")]
        public int PageSize { get; set; } = 10;
    }
}