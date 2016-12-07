using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
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