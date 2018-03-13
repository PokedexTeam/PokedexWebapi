namespace Pokedex.Webapi
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using MySql.Data.MySqlClient;
    using Pokedex.Repositories;
    using Pokedex.Repositories.Repositories;
    using Swashbuckle.AspNetCore.Swagger;
    using System;
    using System.Linq;
    using System.Threading;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PokedexContext>(options => options.UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddTransient<PokemonRepository>();
            services.AddTransient<PokemonSkillRepository>();
            services.AddTransient<PokemonTypeRepository>();

            services.AddMvc();

            services.AddCors();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Pokedex",
                        Version = "v1",
                        Description = "Pokedex Swagger.",
                        TermsOfService = "WTFPL",
                        Contact = new Contact
                        {
                            Email = "",
                            Name = "",
                            Url = ""
                        }
                    }
                );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            app.UseCors(options => options
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<PokedexContext>();

                    context.Database.Migrate();
            }

            app.UseMvc();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pokedex");
            });
        }
    }
}
