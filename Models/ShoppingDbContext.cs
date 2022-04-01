using Microsoft.EntityFrameworkCore;


namespace aspnet_razor_shopping.Models;

public class ShoppingDbContext : DbContext
{

	public ShoppingDbContext(DbContextOptions<ShoppingDbContext> opt) : base(opt) { }


	public DbSet<Cart>? Cart { get; set; }
	public DbSet<Customer>? Customers { get; set; }
	public DbSet<Product>? Products { get; set; }
	public DbSet<Stock>? Stock { get; set; }
}