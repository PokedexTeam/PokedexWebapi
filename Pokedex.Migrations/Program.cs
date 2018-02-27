namespace Pokedex.Migrations
{
    using DbUp;
    using DbUp.Engine;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading;

    class Program
    {
        public static IConfiguration Configuration { get; set; }

        static int Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding.GetEncoding("windows-1254");

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            var connectionString = args.FirstOrDefault() ?? Configuration["ConnectionStrings:MigrateConnection"];

            int retries = Int32.Parse(Configuration["Retries"]);

            int cooldown = Int32.Parse(Configuration["Cooldown"]);

            var migrated = false;
            while (retries > 0 && !migrated)
            {
                try
                {
                    Console.WriteLine($"Retries left {retries}");
                    var upgrader =
                            DeployChanges.To
                                .MySqlDatabase(connectionString)
                                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                                .LogToConsole()
                                .Build();

                    var result = upgrader.PerformUpgrade();

                    if (!result.Successful)
                    {
                        throw new Exception("Migration failed");
                    }

                    migrated = true;
                }
                catch
                {
                    Thread.Sleep(cooldown);
                    retries--;
                }
            }
            return 0;
        }
    }
}
