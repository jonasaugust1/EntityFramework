using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Product")]
    public class Product
    {
        public Product(string name, decimal price, Store store) 
        { 
            Name = name;
            Price = price;
            Store = store;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "{0} can have a max of {1} characters")]
        public string Name { get; set; }

        [MaxLength(2000, ErrorMessage = "{0} can have a max of {1} characters")]
        public string Description { get; set; }

        [Required]
        [Range(0, 99999999999.999, ErrorMessage = "Number out of Range")]
        public decimal Price { get; set; }

        [ForeignKey("Store")]
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }
    }
}