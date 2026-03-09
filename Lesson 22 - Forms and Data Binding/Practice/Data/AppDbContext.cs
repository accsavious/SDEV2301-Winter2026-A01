using Microsoft.EntityFrameworkCore;
using Practice.Models;
namespace Practice.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaskItem> taskItems { get; set; }
        public DbSet<Poll> Polls { get; set; }

    }
}
