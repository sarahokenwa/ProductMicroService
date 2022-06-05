using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductMicroService.Model
{
    [Table("Product")]
    public class Product
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiringDate { get; set; }
        public int CategoryId { get; set; }
        

    }
}
