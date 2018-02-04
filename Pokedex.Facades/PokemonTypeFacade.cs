namespace Pokedex.Facades
{
    using Pokedex.Repositories;
    using Pokedex.Repositories.Models;
    using Pokedex.Repositories.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class PokemonTypeFacade
    {
        public readonly PokedexContext Db;

        public PokemonTypeFacade(PokedexContext _db)
        {
            Db = _db;
        }

        public async Task<IList<PokemonType>> GetAll()
        {
            using (var db = Db)
            {
                var pokemonTypeRepository = new PokemonTypeRepository(db);
                return await pokemonTypeRepository.GetAll();
            }
        }

        public async Task<PokemonType> Get(int id)
        {
            using (var db = Db)
            {
                var pokemonTypeRepository = new PokemonTypeRepository(db);
                return await pokemonTypeRepository.FindOneById(id);
            }
        }

        public async void Insert(List<PokemonType> values)
        {
            using (var db = Db)
            {
                var pokemonTypeRepository = new PokemonTypeRepository(db);

                foreach (var value in values)
                {
                    var pokemonType = await pokemonTypeRepository.FindOneByAttribute(value);

                    if (pokemonType.Count.Equals(0))
                    {
                        pokemonTypeRepository.Insert(value);
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
                var pokemonTypeRepository = new PokemonTypeRepository(db);
                var pokemonType = await pokemonTypeRepository.FindOneById(id);

                pokemonTypeRepository.Delete(pokemonType);
            }
        }

        public async void Update(List<PokemonType> values)
        {
            using (var db = Db)
            {
                var pokemonTypeRepository = new PokemonTypeRepository(db);

                foreach (var value in values)
                {
                    var pokemonType = await pokemonTypeRepository.FindOneById(value.Id);
                    pokemonType.Name = value.Name;

                    pokemonTypeRepository.Update(value);
                }
            }
        }
    }
}
