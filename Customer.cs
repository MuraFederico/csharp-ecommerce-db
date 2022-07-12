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

    public static void Create(string name, string surname, string email)
    {
        using(EcommerceContext context = new EcommerceContext())
        {
            Customer customer = new Customer { Name = name, Surname = surname, Email = email};
            context.Add(customer);
            context.SaveChanges();
        }
    }
}

