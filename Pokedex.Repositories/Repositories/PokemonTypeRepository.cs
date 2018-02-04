namespace Pokedex.Repositories.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using Pokedex.Repositories.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PokemonTypeRepository : IRepository<PokemonType>
    {
        public readonly PokedexContext Db;
        public PokemonTypeRepository(PokedexContext db)
        {
            Db = db;
        }

        public async Task<PokemonType> FindOneById(int id)
        {
            return await Db.PokemonTypes.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public async Task<IList<PokemonType>> GetAll()   
        {
            return await Db.PokemonTypes.ToListAsync();
        }

        public async Task<IList<PokemonType>> FindOneByAttribute(PokemonType pType)
        {
            return await Db.PokemonTypes.Where(x => x.Name.Equals(pType.Name) || x.Id.Equals(pType.Id)).ToListAsync();
        }

        public void Insert(PokemonType value)
        {
            Db.PokemonTypes.Add(value);
            Db.SaveChanges();
        }

        public void Update(PokemonType value)
        {
            Db.PokemonTypes.Update(value);
            Db.SaveChanges();
        }

        public void Delete(PokemonType pokemonType)
        {
            Db.PokemonTypes.Remove(pokemonType);
            Db.SaveChanges();
        }
    }
}
