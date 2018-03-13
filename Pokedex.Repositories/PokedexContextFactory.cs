namespace Pokedex.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.IO;
    using Microsoft.Extensions.Configuration;
    using System.Linq;
    using Microsoft.EntityFrameworkCore.Design;

    public class PokedexContextFactory : IDesignTimeDbContextFactory<PokedexContext>
    {
        private IConfiguration Configuration;

        public PokedexContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            var connectionString = args.FirstOrDefault() ?? Configuration["ConnectionStrings:MigrateConnection"];

            var contextOptionsBuilder = new DbContextOptionsBuilder<PokedexContext>();

            contextOptionsBuilder.UseMySql(connectionString);

            return new PokedexContext(contextOptionsBuilder.Options);
        }
    }
}
