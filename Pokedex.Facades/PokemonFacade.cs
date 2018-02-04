namespace Pokedex.Facades
{
    using Pokedex.Repositories;
    using Pokedex.Repositories.Models;
    using Pokedex.Repositories.Repositories;
    using Pokedex.Webapi.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;

    public class PokemonFacade
    {
        public readonly PokedexContext Db;

        public PokemonFacade(PokedexContext _db)
        {
            Db = _db;
        }

        public async Task<IList<PokemonResponse>> GetAll()
        {
            using (var db = Db)
            {
                var pokemonRepository = new PokemonRepository(db);

                var pokemons = await pokemonRepository.GetAll();

                var pokemonResponse = new List<PokemonResponse>();

                foreach (var pokemon in pokemons)
                {
                    pokemonResponse.Add(
                        new PokemonResponse()
                        {
                            Id = pokemon.Id,
                            Name = pokemon.Name,
                            BaseAttack = pokemon.BaseAttack,
                            BaseDefense = pokemon.BaseDefense,
                            BaseHP = pokemon.BaseHP,
                            BaseSpAtk = pokemon.BaseSpAtk,
                            BaseSpDef = pokemon.BaseSpDef,
                            BaseSpeed = pokemon.BaseSpeed,
                            Skills = await GetPokemonSkills(pokemon.Id, db),
                            Types = await GetPokemonTypes(pokemon.Id, db)
                        });
                }
                return pokemonResponse;
            }
        }

        private async Task<List<PokemonType>> GetPokemonTypes(int id, PokedexContext db)
        {
            var pokemonToPokemonTypeRepository = new PokemonToPokemonTypeRepository(db);
            var task = await pokemonToPokemonTypeRepository.GetByPokemonId(id);
            var results = task.Select(x => x.PokemonTypeId);

            var pokemonTypeRepository = new PokemonTypeRepository(db);
            var task2 = await pokemonTypeRepository.GetAll();
            return task2.Where(x => results.Contains(x.Id)).ToList();

        }

        private async Task<List<PokemonSkill>> GetPokemonSkills(int id, PokedexContext db)
        {
            var pokemonToPokemonSkillRepository = new PokemonToPokemonSkillRepository(db);
            var task = await pokemonToPokemonSkillRepository.GetByPokemonId(id);
            var results = task.Select(x => x.PokemonSkillId);

            var pokemonSkillRepository = new PokemonSkillRepository(db);
            var task2 = await pokemonSkillRepository.GetAll();
            return task2.Where(x => results.Contains(x.Id)).ToList();
        }

        public async Task<PokemonResponse> Get(int id)
        {
            using (var db = Db)
            {
                var pokemonRepository = new PokemonRepository(db);

                var pokemon = await pokemonRepository.FindOneById(id);

                var pokemonResponse = new PokemonResponse()
                {
                    Id = pokemon.Id,
                    Name = pokemon.Name,
                    BaseAttack = pokemon.BaseAttack,
                    BaseDefense = pokemon.BaseDefense,
                    BaseHP = pokemon.BaseHP,
                    BaseSpAtk = pokemon.BaseSpAtk,
                    BaseSpDef = pokemon.BaseSpDef,
                    BaseSpeed = pokemon.BaseSpeed,
                    Skills = await GetPokemonSkills(pokemon.Id, db),
                    Types = await GetPokemonTypes(pokemon.Id, db)
                };
                return pokemonResponse;
            }
        }

        public void Insert(List<PokemonResponse> values)
        {
            using (var db = Db)
            {
                var pokemonRepository = new PokemonRepository(db);

                foreach (var value in values)
                {
                    var pokemon = new Pokemon()
                    {
                        Id = value.Id,
                        Name = value.Name,
                        BaseAttack = value.BaseAttack,
                        BaseDefense = value.BaseDefense,
                        BaseHP = value.BaseHP,
                        BaseSpAtk = value.BaseSpAtk,
                        BaseSpDef = value.BaseSpDef,
                        BaseSpeed = value.BaseSpeed,
                    };
                    pokemonRepository.Insert(pokemon);

                    var pokemonToPokemonSkillRepository = new PokemonToPokemonSkillRepository(db);
                    foreach (var skill in value.Skills)
                    {
                        var newMap = new PokemonToPokemonSkill()
                        {
                            PokemonId = value.Id,
                            PokemonSkillId = skill.Id
                        };
                        pokemonToPokemonSkillRepository.Insert(newMap);
                    }

                    var pokemonToPokemonTypeRepository = new PokemonToPokemonTypeRepository(db);
                    foreach (var type in value.Types)
                    {
                        var newMap = new PokemonToPokemonType()
                        {
                            PokemonId = value.Id,
                            PokemonTypeId = type.Id
                        };
                        pokemonToPokemonTypeRepository.Insert(newMap);
                    }
                }
            }
        }

        public async void Delete(int id)
        {
            using (var db = Db)
            {
                var pokemonToPokemonSkillRepository = new PokemonToPokemonSkillRepository(db);
                var skillMaps = await pokemonToPokemonSkillRepository.GetByPokemonId(id);
                foreach (var skillMap in skillMaps)
                {
                    pokemonToPokemonSkillRepository.Delete(skillMap);
                }

                var pokemonToPokemonTypeRepository = new PokemonToPokemonTypeRepository(db);
                var typeMaps = await pokemonToPokemonTypeRepository.GetByPokemonId(id);
                foreach (var typeMap in typeMaps)
                {
                    pokemonToPokemonTypeRepository.Delete(typeMap);
                }

                var pokemonRepository = new PokemonRepository(db);
                var pokemon = await pokemonRepository.FindOneById(id);
                pokemonRepository.Delete(pokemon);
            }
        }

        public async void Update(List<PokemonResponse> values)
        {
            using (var db = Db)
            {
                var pokemonRepository = new PokemonRepository(db);

                foreach (var value in values)
                {
                    var pokemon = await pokemonRepository.FindOneById(value.Id);
                    pokemon.Name = value.Name;
                    pokemon.BaseAttack = value.BaseAttack;
                    pokemon.BaseDefense = value.BaseDefense;
                    pokemon.BaseHP = value.BaseHP;
                    pokemon.BaseSpAtk = value.BaseSpAtk;
                    pokemon.BaseSpDef = value.BaseSpDef;
                    pokemon.BaseSpeed = value.BaseSpeed;

                    pokemonRepository.Update(pokemon);

                    var pokemonToPokemonSkillRepository = new PokemonToPokemonSkillRepository(db);
                    var task = await pokemonToPokemonSkillRepository.GetByPokemonId(value.Id);
                    var oldSkills = task.ToList();

                    var newSkills = value.Skills.Where(p => !oldSkills.Any(p2 => p2.PokemonSkillId.Equals(p.Id)));
                    foreach (var skill in newSkills)
                    {
                        var skillMap = new PokemonToPokemonSkill()
                        {
                            PokemonId = value.Id,
                            PokemonSkillId = skill.Id
                        };
                        pokemonToPokemonSkillRepository.Insert(skillMap);
                    }

                    var removedSkills = oldSkills.Where(p => !value.Skills.Any(p2 => p2.Id.Equals(p.PokemonSkillId)));
                    foreach (var skill in removedSkills)
                    {
                        pokemonToPokemonSkillRepository.Delete(skill);
                    }

                    var pokemonToPokemonTypeRepository = new PokemonToPokemonTypeRepository(db);
                    var oldTypes = await pokemonToPokemonTypeRepository.GetByPokemonId(value.Id);

                    var newTypes = value.Types.Where(p => !oldTypes.Any(p2 => p2.PokemonTypeId.Equals(p.Id)));
                    foreach (var type in newTypes)
                    {
                        var typeMap = new PokemonToPokemonType()
                        {
                            PokemonId = value.Id,
                            PokemonTypeId = type.Id
                        };
                        pokemonToPokemonTypeRepository.Insert(typeMap);
                    }

                    var removedTypes = oldTypes.Where(p => !value.Types.Any(p2 => p2.Id.Equals(p.PokemonTypeId)));
                    foreach (var type in removedTypes)
                    {
                        pokemonToPokemonTypeRepository.Delete(type);
                    }

                }
            }
        }
    }
}
