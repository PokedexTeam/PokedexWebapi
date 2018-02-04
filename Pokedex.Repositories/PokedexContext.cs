namespace Pokedex.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using Pokedex.Repositories.Models;

    public class PokedexContext : DbContext
    {
        public DbSet<PokemonType> PokemonTypes { get; set; }

        public DbSet<PokemonSkill> PokemonSkills { get; set; }

        public DbSet<Pokemon> Pokemons { get; set; }

        public DbSet<PokemonToPokemonSkill> PokemonToPokemonSkills { get; set; }

        public DbSet<PokemonToPokemonType> PokemonToPokemonTypes { get; set; }

        private string ConnectionString;

        public PokedexContext(string con)
        {
            ConnectionString = con;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConnectionString);
        }
    }
}
