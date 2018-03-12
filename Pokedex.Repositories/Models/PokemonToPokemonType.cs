using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Repositories.Models
{
    public class PokemonToPokemonType 
    {
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }

        public int PokemonTypeId { get; set; }
        public PokemonType PokemonType { get; set; }
    }
}