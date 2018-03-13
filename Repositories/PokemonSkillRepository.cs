namespace pokedex.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using pokedex.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PokemonSkillRepository
    {
        public readonly PokedexContext Db;
        public PokemonSkillRepository(PokedexContext db)
        {
            Db = db;
        }

        public async Task<PokemonSkill> Get(int id)
        {
            return await Db.PokemonSkills.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public async Task<IList<PokemonSkill>> Get()   
        {
            return await Db.PokemonSkills.ToListAsync();
        }

        public async Task<IList<PokemonSkill>> Get(PokemonSkill pokemonSkill)
        {
            return await Db.PokemonSkills.Where(x => x.Name.Equals(pokemonSkill.Name) || x.Id.Equals(pokemonSkill.Id)).ToListAsync();
        }

        public void Insert(PokemonSkill value)
        {
            Db.PokemonSkills.Add(value);
            Db.SaveChanges();
        }

        public void Update(PokemonSkill value)
        {
            Db.PokemonSkills.Update(value);
            Db.SaveChanges();
        }

        public void Delete(PokemonSkill pokemonSkill)
        {
            Db.PokemonSkills.Remove(pokemonSkill);
            Db.SaveChanges();
        }
    }
}