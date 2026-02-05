using Microsoft.EntityFrameworkCore;

namespace EFCoreLesson
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=school.db");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            using var context = new SchoolContext();

            context.Database.EnsureCreated();

            if (!context.Students.Any())
            {
                context.Students.AddRange(
                    new Student { Name = "Alice", Age = 20 },
                    new Student { Name = "Bob", Age = 22 },
                    new Student { Name = "Charlie", Age = 19 }
                );
                context.SaveChanges();
                Console.WriteLine("Database seeded with sample students.");
            }

            List<Student> students = context.Students
                                            .OrderBy(s => s.Id)
                                            .ToList();

            Console.WriteLine("\nAll Students in Database:");
            foreach (var s in students)
            {
                Console.WriteLine($"ID={s.Id}, Name={s.Name}, Age={s.Age}");
            }

        }
    }
}
