using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace EfCoreNeighborhood
{
    public class Neighborhood
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public char District { get; set; }
        public List<House> Houses { get; set; } = new();
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

    internal class Program
    {
        static void Main(string[] args)
        {
            

            //CreateNeighborhood(context);
            //Neighborhood neighborhood = GetOnlyNeighborhoodByName(context, "Garneau");
            //Console.WriteLine("Created New Neighborhood");
            //PrintNeighborhood(neighborhood);

            //if (neighborhood != null)
                //CreateHouses(context, neighborhood);

            //Console.WriteLine("Added houses to Neighborhood");
            //neighborhood = GetNeighborhoodAndHousesByName(context, "Garneau");
            //PrintNeighborhood(neighborhood);

            //UpdateDistrict(context, neighborhood, 'G');
            //UpdateAddress(context, 2, "999 Pizza Place");
            //neighborhood = GetNeighborhoodAndHousesByName(context, "Garneau");
            //PrintNeighborhood(neighborhood);

            //RemoveHouseById(context, 1);
            //neighborhood = GetNeighborhoodAndHousesByName(context, "Garneau");
            //PrintNeighborhood(neighborhood);

            //RemoveNeighborhood(context, neighborhood);
            //neighborhood = GetNeighborhoodAndHousesByName(context, "Garneau");
            //PrintNeighborhood(neighborhood);
        }
    }
}
