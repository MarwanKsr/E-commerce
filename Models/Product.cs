using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public bool? IsActive { get; set; } = true;
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string? Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int? Stock { get; set; }
        Category category { get; set; }
    }
}
