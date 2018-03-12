using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Repositories.Models
{
    public class PokemonToPokemonSkill 
    {
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }

        public int PokemonSkillId { get; set; }
        public PokemonSkill PokemonSkill { get; set; }
    }
}