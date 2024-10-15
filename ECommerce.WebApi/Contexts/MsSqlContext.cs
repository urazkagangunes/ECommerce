using ECommerce.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.WebApi.Contexts;

public class MsSqlContext : DbContext
{
    public MsSqlContext(DbContextOptions opt) : base(opt)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Ecommerce_db;User Id=sa;Password=admin1234567;TrustServerCertificate=true");
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

}
