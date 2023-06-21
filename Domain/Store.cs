using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Store")]
    public class Store
    {
        public Store(string name) 
        {
            Name = name;
            Products = new List<Product>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "{0} can have a max of {1} characters")]
        public string Name { get; set; }

        [MaxLength(2000, ErrorMessage = "{0} can have a max of {1} characters")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
