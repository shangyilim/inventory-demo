using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(100)]
        public string Image { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        public double costPrice { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double sellingPrice { get; set; }
    }
}