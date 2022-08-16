using e_commerce.Models;

namespace e_commerce.ViewModels
{
    public class UpdateProductVM
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int? Stock { get; set; }
        Category? category { get; set; }
        public bool? IsActive { get; set; }

    }
}
