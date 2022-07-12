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
    [Column(TypeName = "decimal(8, 2)")]
    public decimal Price { get; set; }

    public List<Order> Orders { get; set; }

    public List<OrderProduct> OrderProducts { get; set; }

    public static void Create(string name, decimal price, string description = null)
    {
        using(EcommerceContext context = new EcommerceContext())
        {
            Product product = new Product { Name = name, Price = price, Description = description};
            context.Add(product);
            context.SaveChanges();
        }

    }

}

