using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



[Table("customer")]
public class Customer
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    [Required]
    public string Surname { get; set; }

        
    [EmailAddress]
    [Required]
    public string Email { get; set; }

    public List<Order> CustomerOrders { get; set; }
}

