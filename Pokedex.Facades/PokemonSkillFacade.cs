namespace Pokedex.Facades
{
    using Pokedex.Repositories;
    using Pokedex.Repositories.Models;
    using Pokedex.Repositories.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class PokemonSkillFacade
    {
        public readonly PokedexContext Db;

        public PokemonSkillFacade(PokedexContext _db)
        {
            Db = _db;
        }

        public async Task<IList<PokemonSkill>> GetAll()
        {
            using (var db = Db)
            {
                var pokemonSkillRepository = new PokemonSkillRepository(db);
                return await pokemonSkillRepository.GetAll();
            }
        }

        public async Task<PokemonSkill> Get(int id)
        {
            using (var db = Db)
            {
                var pokemonSkillRepository = new PokemonSkillRepository(db);
                return await pokemonSkillRepository.FindOneById(id);
            }
        }

        public async void Insert(List<PokemonSkill> values)
        {
            using (var db = Db)
            {
                var pokemonSkillRepository = new PokemonSkillRepository(db);

                foreach (var value in values)
                {
                    var pokemonSkill = await pokemonSkillRepository.FindOneByAttribute(value);

                    if (pokemonSkill.Count.Equals(0))
                    {
                        pokemonSkillRepository.Insert(value);
                    }
                    else
                    {
                        // Log error for DuplicateException Id or Name already exists in table
                    }
                }
            }
        }

        public async void Delete(int id)
        {
            using (var db = Db)
            {
                var pokemonSkillRepository = new PokemonSkillRepository(db);
                var pokemonSkill = await pokemonSkillRepository.FindOneById(id);

                pokemonSkillRepository.Delete(pokemonSkill);
            }
        }

        public async void Update(List<PokemonSkill> values)
        {
            using (var db = Db)
            {
                var pokemonSkillRepository = new PokemonSkillRepository(db);

                foreach (var value in values)
                {
                    var pokemonType = await pokemonSkillRepository.FindOneById(value.Id);
                    pokemonType.Name = value.Name;

                    pokemonSkillRepository.Update(value);
                }
            }
        }
    }
}
