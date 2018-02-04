namespace Pokedex.Repositories.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using Pokedex.Repositories.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PokemonToPokemonTypeRepository : IRepository<PokemonToPokemonType>
    {
        public readonly PokedexContext Db;
        public PokemonToPokemonTypeRepository(PokedexContext db)
        {
            Db = db;
        }

        public async Task<IList<PokemonToPokemonType>> GetByPokemonId(int id)
        {
            return await Db.PokemonToPokemonTypes.Where(x => x.PokemonId.Equals(id)).ToListAsync();
        }

        public async Task<PokemonToPokemonType> FindOneById(int id)
        {
            return await Db.PokemonToPokemonTypes.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public async Task<IList<PokemonToPokemonType>> GetAll()   
        {
            return await Db.PokemonToPokemonTypes.ToListAsync();
        }

        public async Task<IList<PokemonToPokemonType>> FindOneByAttribute(PokemonToPokemonType pType)
        {
            return await Db.PokemonToPokemonTypes.Where(x => x.PokemonId.Equals(pType.PokemonId) || x.PokemonTypeId.Equals(pType.PokemonTypeId)).ToListAsync();
        }

        public void Insert(PokemonToPokemonType value)
        {
            Db.PokemonToPokemonTypes.Add(value);
            Db.SaveChanges();
        }

        public void Update(PokemonToPokemonType value)
        {
            Db.PokemonToPokemonTypes.Update(value);
            Db.SaveChanges();
        }

        public void Delete(PokemonToPokemonType pokemonType)
        {
            Db.PokemonToPokemonTypes.Remove(pokemonType);
            Db.SaveChanges();
        }
    }
}
