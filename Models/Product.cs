using System.ComponentModel.DataAnnotations;

namespace Bakery.WebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        [Range(0.01, 9999.99)]
        public decimal Price { get; set; }

        [Required]
        public string ImageName { get; set; }
    }
}