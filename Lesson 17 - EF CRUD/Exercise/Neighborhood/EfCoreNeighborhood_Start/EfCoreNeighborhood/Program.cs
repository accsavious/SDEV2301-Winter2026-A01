using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace EfCoreNeighborhood
{
    public class Neighborhood
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 94f237f2eb83d89fc3bef24e7fa7338835703115
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public char District { get; set; }
        public List<House> Houses { get; set; } = new();
<<<<<<< HEAD
    }

    public class House
    {
        public int Id { get; set; }
        public string Address { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public int NeighborhoodId { get; set; }
        public Neighborhood? Neighborhood { get; set; }
    }

    public class ResedentialContext : DbContext
    {
        public DbSet<Neighborhood> Neighborhoods => Set<Neighborhood>();
        public DbSet<House> Houses => Set<House>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "residential.db");
            dbPath = Path.GetFullPath(dbPath);
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<House>(h =>
            {
                h.Property(h => h.Address).HasMaxLength(80).IsRequired();
                h.Property(h => h.PostalCode).HasMaxLength(6).IsRequired();
            });
            modelBuilder.Entity<Neighborhood>(n =>
            {
                n.Property(n => n.Name).HasMaxLength(100).IsRequired();
                n.Property(n => n.District).IsRequired();
                n.HasMany(n => n.Houses).WithOne(h => h.Neighborhood)
                .HasForeignKey(h => h.NeighborhoodId).OnDelete(DeleteBehavior.Cascade);
            });
        }
    }

=======
    }

    public class House
    {
        public int Id { get; set; }
        public string Address { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public int NeighborhoodId { get; set; }
        public Neighborhood Neighborhood { get; set; }
    }

    public class ResidentialContext : DbContext
    {
        public DbSet<Neighborhood> Neighborhoods => Set<Neighborhood>();
        public DbSet<House> Houses => Set<House>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "app.db");
            dbPath = Path.GetFullPath(dbPath);

            optionsBuilder
        }
    }

=======
        public string name { get; set; }

    }
>>>>>>> 1dc6a0ae80db34b63c9f8ecb1a7ae6218fc7f26e
>>>>>>> 94f237f2eb83d89fc3bef24e7fa7338835703115
    internal class Program
    {
        static void Main(string[] args)
        {

            using var context = new ResedentialContext();
            context.Database.Migrate();
            var serve = new NeighborhoodServices();
            serve.CreateNeighborhood(context);
            Neighborhood? neighborhood = serve.GetOnlyNeighborhoodByName(context, "Garneau");
            Console.WriteLine("Created New Neighborhood");
            serve.PrintNeighborhood(neighborhood);

            if (neighborhood != null)
            serve.CreateHouses(context, neighborhood);

            Console.WriteLine("Added houses to Neighborhood");
            neighborhood = serve.GetNeighborhoodAndHousesByName(context, "Garneau");
            serve.PrintNeighborhood(neighborhood);

            serve.UpdateDistrict(context, neighborhood, 'G');
            serve.UpdateAddress(context, 2, "999 Pizza Place");
            neighborhood = serve.GetNeighborhoodAndHousesByName(context, "Garneau");
            serve.PrintNeighborhood(neighborhood);

            serve.RemoveHouseById(context, 1);
            neighborhood = serve.GetNeighborhoodAndHousesByName(context, "Garneau");
            serve.PrintNeighborhood(neighborhood);

            serve.RemoveNeighborhood(context, neighborhood);
            neighborhood = serve.GetNeighborhoodAndHousesByName(context, "Garneau");
            serve.PrintNeighborhood(neighborhood);
        }
    }
}
