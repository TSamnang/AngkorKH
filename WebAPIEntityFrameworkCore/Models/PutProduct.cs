using System.ComponentModel.DataAnnotations;

namespace WebAPIEntityFrameworkCore.Models
{
    public class PutProduct
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a Positive Number")]
        public double Price { get; set; }
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Qty must be a Postive Number")]
        public int Qty { get; set; }
        
        public IFormFile? Image { get; set; }
    }
}
