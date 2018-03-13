namespace pokedex.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using pokedex.Models;

    public class PokedexContext : DbContext
    {
        public DbSet<PokemonType> PokemonTypes { get; set; }

        public DbSet<PokemonSkill> PokemonSkills { get; set; }

        public DbSet<Pokemon> Pokemons { get; set; }

        public PokedexContext(DbContextOptions<PokedexContext> options)
          : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonToPokemonSkill>()
                .HasKey(t => new { t.PokemonId, t.PokemonSkillId });

            modelBuilder.Entity<PokemonToPokemonSkill>()
                .HasOne(pt => pt.Pokemon)
                .WithMany(p => p.PokemonToPokemonSkills)
                .HasForeignKey(pt => pt.PokemonId);

            modelBuilder.Entity<PokemonToPokemonSkill>()
                .HasOne(pt => pt.PokemonSkill)
                .WithMany(t => t.PokemonToPokemonSkills)
                .HasForeignKey(pt => pt.PokemonSkillId);

            modelBuilder.Entity<PokemonToPokemonType>()
                .HasKey(t => new { t.PokemonId, t.PokemonTypeId });

            modelBuilder.Entity<PokemonToPokemonType>()
                .HasOne(pt => pt.Pokemon)
                .WithMany(p => p.PokemonToPokemonTypes)
                .HasForeignKey(pt => pt.PokemonId);

            modelBuilder.Entity<PokemonToPokemonType>()
                .HasOne(pt => pt.PokemonType)
                .WithMany(t => t.PokemonToPokemonTypes)
                .HasForeignKey(pt => pt.PokemonTypeId);
        }
    }
}
