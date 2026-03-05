using EfCoreBlazorDemo.Models;
using Microsoft.EntityFrameworkCore;
namespace EFCore_Blazor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
