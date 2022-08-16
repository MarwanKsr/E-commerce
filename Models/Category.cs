using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, ErrorMessage ="Name must be at much 25 character")]
        [MinLength(3, ErrorMessage ="Name must be at least 3 character")]
        public string Name { get; set; }

        public ICollection<Product>? products { get; set; }
    }
}
