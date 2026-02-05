using Microsoft.EntityFrameworkCore;
namespace EFDemo
{

    public class Student
    {
        public int Id { get; set; }
        // an int named Id will automatically be designated
        // as the primary key
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Etudients { get; set; } // this represents a table
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=school.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { // we can build constraints here
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new SchoolContext();
            context.Database.EnsureCreated();

            if (!context.Etudients.Any())
            {
                context.Etudients.AddRange(
                    new Student { Name = "Me", Age = 80000 },
                    new Student { Name = "The Doctor", Age = 0 },
                    new Student { Name = "Rose Tyler", Age = 19 }
                    );
            }
            context.SaveChanges();

            List<Student> students = context.Etudients
                .Where(s => s.Age < 1000)
                .OrderBy(s => s.Age)
                .ToList();
            
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Id}, {student.Name} {student.Age}");
            }
        }
    }
}
