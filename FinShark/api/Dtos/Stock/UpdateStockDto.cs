using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Stock
{
    public class UpdateStockDto
    {

        [Required]
        [MaxLength(10, ErrorMessage = "Symbol must be less than 10 characters")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(10, ErrorMessage = "Company Name must be less than 10 characters")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 1_000_000_000_000, ErrorMessage = "Purchase must be between [1, 1_000_000_000_000]")]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 100, ErrorMessage = "LastDiv must be between [0.001, 100]")]
        public decimal LastDiv { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Industry must be less than 10 characters")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 5_000_000_000_000, ErrorMessage = "MarketCap must be between [1, 5_000_000_000_000]")]
        public long MarketCap { get; set; }

    }
}