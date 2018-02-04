namespace Pokedex.Repositories.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using Pokedex.Repositories.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PokemonToPokemonSkillRepository : IRepository<PokemonToPokemonSkill>
    {
        public readonly PokedexContext Db;
        public PokemonToPokemonSkillRepository(PokedexContext db)
        {
            Db = db;
        }

        public async Task<IList<PokemonToPokemonSkill>> GetByPokemonId(int id)
        {
            return await Db.PokemonToPokemonSkills.Where(x => x.PokemonId.Equals(id)).ToListAsync();
        }

        public async Task<PokemonToPokemonSkill> FindOneById(int id)
        {
            return await Db.PokemonToPokemonSkills.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public async Task<IList<PokemonToPokemonSkill>> GetAll()   
        {
            return await Db.PokemonToPokemonSkills.ToListAsync();
        }

        public async Task<IList<PokemonToPokemonSkill>> FindOneByAttribute(PokemonToPokemonSkill pType)
        {
            return await Db.PokemonToPokemonSkills.Where(x => x.PokemonId.Equals(pType.PokemonId) || x.PokemonSkillId.Equals(pType.PokemonSkillId)).ToListAsync();
        }

        public void Insert(PokemonToPokemonSkill value)
        {
            Db.PokemonToPokemonSkills.Add(value);
            Db.SaveChanges();
        }

        public void Update(PokemonToPokemonSkill value)
        {
            Db.PokemonToPokemonSkills.Update(value);
            Db.SaveChanges();
        }

        public void Delete(PokemonToPokemonSkill pokemonType)
        {
            Db.PokemonToPokemonSkills.Remove(pokemonType);
            Db.SaveChanges();
        }
    }
}
