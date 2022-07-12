using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



[Table("product")]
public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string Description { get; set; }

    [Required]
    [Column(TypeName = "decimal(5, 2)")]
    public decimal Price { get; set; }

    public List<Order> Orders { get; set; }

    public List<OrderProduct> OrderProducts { get; set; }

}

