using Microsoft.EntityFrameworkCore;

public class ShoppingDbContext : DbContext
{

	public ShoppingDbContext(DbContextOptions<ShoppingDbContext> opt) : base(opt) { }


}