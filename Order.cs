using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



[Table("order")]

public class Order
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    [Column(TypeName = "decimal(5, 2)")]
    public decimal Amount { get; set; }

    [Required]
    public string Status { get; set; }

    [Column("customer_id")]
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public List<Product> Products { get; set; }

    public List<OrderProduct> OrderProducts { get; set; }
}

