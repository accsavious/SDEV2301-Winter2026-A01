using L26Exercise.Models;
using Microsoft.EntityFrameworkCore;


namespace L26Exercise.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItems => Set<TaskItem>();
        public DbSet<Poll> Polls => Set<Poll>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
    }
}
