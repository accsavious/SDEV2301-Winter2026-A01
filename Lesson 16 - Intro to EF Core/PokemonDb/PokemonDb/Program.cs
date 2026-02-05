using Microsoft.EntityFrameworkCore;

namespace PokemonDb
{
    internal class Program
    {
        public class Pokemon
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public int Level { get; set; }
            public DateTime CaughtDate { get; set; }

        }
        public class GymLeader
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Town { get; set; }
            public string Type { get; set; }
        }
        public class PokemonContext : DbContext
        {
            public DbSet<Pokemon> Pokemons { get; set; }
            public DbSet<GymLeader> GymLeaders { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=pokemon.db");
            }
        }
        static void Main(string[] args)
        {
            using var context = new PokemonContext();
            context.Database.EnsureCreated();
            if (!context.Pokemons.Any())
            {
                context.Pokemons.Add(new Pokemon
                {
                    Name = "Pikachu",
                    Type = "Electric",
                    Level = 12,
                    CaughtDate = DateTime.Parse("2025-01-01")
                });

                context.Pokemons.Add(new Pokemon
                {
                    Name = "Charmander",
                    Type = "Fire",
                    Level = 10,
                    CaughtDate = DateTime.Parse("2025-05-05")
                });
                context.Pokemons.Add(new Pokemon
                {
                    Name = "Ditto",
                    Type = "Normal",
                    Level = 22,
                    CaughtDate = DateTime.Parse("2025-09-09")
                });

                context.GymLeaders.Add(new GymLeader
                {
                    Name = "Brock",
                    Type = "Rock",
                    Town = "Can't remember"
                });
                context.GymLeaders.Add(new GymLeader
                {
                    Name = "Misty",
                    Type = "Water",
                    Town = "Water Village?"
                });
                context.GymLeaders.Add(new GymLeader
                {
                    Name = "Gary",
                    Type = "Water/Dragon",
                    Town = "Elite Mountain"
                });

                context.SaveChanges();
            }

            foreach (Pokemon pokemon in context.Pokemons)
            {
                Console.WriteLine($"{pokemon.Name} is a level {pokemon.Level} {pokemon.Type} type.");
            }
            Console.WriteLine("-------------");
            // Pokemon of certain level
            var certainLevelPokemon = context.Pokemons.Where(p => p.Level >= 20);
            foreach (Pokemon pokemon in certainLevelPokemon)
            {
                Console.WriteLine($"{pokemon.Name} is a level {pokemon.Level} {pokemon.Type} type.");
            }

            Console.WriteLine("-------------");
            // Pokemon sorted by highest level
            var highestLevelSort = context.Pokemons.OrderByDescending(p => p.Level);

            foreach (Pokemon pokemon in highestLevelSort)
            {
                Console.WriteLine($"{pokemon.Name} is a level {pokemon.Level} {pokemon.Type} type.");
            }

            Console.WriteLine("-------------");

            int numPokemon = context.Pokemons.Count();
            Console.WriteLine($"Number of pokemon: {numPokemon}.");

            Console.WriteLine("-------------");

            var gymLeaders = context.GymLeaders.OrderBy(g => g.Type).ThenBy(g => g.Name);

            foreach (GymLeader leader in context.GymLeaders)
            {
                Console.WriteLine($"{leader.Name} is a {leader.Type} trainer in {leader.Town}.");
            }
        }
    }
}
