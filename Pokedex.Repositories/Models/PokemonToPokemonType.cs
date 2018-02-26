using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Repositories.Models
{
    public class PokemonToPokemonType : IModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PokemonId { get; set; }
        public int PokemonTypeId { get; set; }
    }
}