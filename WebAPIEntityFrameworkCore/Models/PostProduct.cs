using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace WebAPIEntityFrameworkCore.Models
{
    public class PostProduct
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage ="Price must be a Positive Number")]
        public double Price { get; set; }
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Qty must be a Postive Number")]
        public int Qty { get; set; }
        [Required]
        public IFormFile Image { get; set; } = null!;

    }
}
