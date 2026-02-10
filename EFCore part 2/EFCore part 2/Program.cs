using Microsoft.EntityFrameworkCore;
namespace EFCore_part_2
{
    public class Course

    {

        public int Id { get; set; }

        public string Code { get; set; } = "";

        public string Name { get; set; } = "";

        public int Credits { get; set; } = 3;
        // Collection navigation property
        public List<Student> Students { get; set; } = new();
    }

    public class Student

    {

        public int Id { get; set; }

        public string Name { get; set; } = "";

        public int Age { get; set; }
        // Reference navigation property
        public Course? Course { get; set; }
        // Foreign Key
        public int CourseId { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Student> Students => Set<Student>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "school.db"

            );
            dbPath = Path.GetFullPath(dbPath);
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(b =>
            {
                b.Property(s => s.Name).IsRequired().HasMaxLength(100);
                
            });
            modelBuilder.Entity<Course>(b =>
            {
                b.Property(c => c.Name).IsRequired().HasMaxLength(100);
                b.Property(c => c.Code).IsRequired().HasMaxLength(20);
                b.HasMany(c => c.Students)
                .WithOne(s => s.Course!)
                .HasForeignKey(s => s.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new SchoolContext();
            context.Database.Migrate();
            SchoolService service = new SchoolService();
            service.CreateExample(context);
            service.UpdateExample(context);
            service.ReadExample(context);
            service.DeleteExample(context);
        }
    }
}
