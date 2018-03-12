namespace Pokedex.Repositories.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using Pokedex.Repositories.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PokemonRepository
    {
        public readonly PokedexContext Db;
        public PokemonRepository(PokedexContext db)
        {
            Db = db;
        }

        public async Task<Pokemon> FindOneById(int id)
        {
            return await Db.Pokemons
                .Where(x => x.Id.Equals(id))
                .FirstOrDefaultAsync();
        }

        public async Task<IList<Pokemon>> FindOneByAttribute(Pokemon value)
        {
            return await Db.Pokemons.Where(x =>
                            x.Name.Equals(value.Name) ||
                            x.Id.Equals(value.Id) ||
                            x.BaseAttack.Equals(value.Id) ||
                            x.BaseDefense.Equals(value.Id) ||
                            x.BaseHP.Equals(value.Id) ||
                            x.BaseSpAtk.Equals(value.Id) ||
                            x.BaseSpeed.Equals(value.Id))
                            .ToListAsync();
        }

        public async Task<IList<Pokemon>> GetAll()
        {
            return await Db.Pokemons.ToListAsync();
        }

        public void Insert(Pokemon value)
        {
            Db.Pokemons.Add(value);
            Db.SaveChanges();
        }

        public void Update(Pokemon value)
        {
            Db.Pokemons.Update(value);
            Db.SaveChanges();
        }

        public void Delete(Pokemon value)
        {
            Db.Pokemons.Remove(value);
            Db.SaveChanges();
        }
    }
}
