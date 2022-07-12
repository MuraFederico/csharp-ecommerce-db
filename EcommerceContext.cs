using Microsoft.EntityFrameworkCore;

public class EcommerceContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }

    /*public DbSet<OrderProduct> OrdersProducts { get; set; }*/
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasMany(p => p.Products)
            .WithMany(p => p.Orders)
            .UsingEntity<OrderProduct>(
                j => j
                    .HasOne(pt => pt.Product)
                    .WithMany(t => t.OrderProducts)
                    .HasForeignKey(pt => pt.ProductId),
                j => j
                    .HasOne(pt => pt.Order)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(pt => pt.OrderId),
                j =>
                {
                    j.Property(pt => pt.Quantity);
                    j.HasKey(t => new { t.OrderId, t.ProductId });
                });
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=E-commerce;Integrated Security=True");
    }

}