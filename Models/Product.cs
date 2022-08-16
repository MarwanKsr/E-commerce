using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; } = string.Empty;
        [Display(Name ="Is Active?")]
        public bool? IsActive { get; set; } = true;
        [Display(Name ="Created Date")]
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string? Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int? Stock { get; set; }
        Category category { get; set; }
    }
}
