using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Repositories.Models
{
    [Table("pokemontopokemonskill")]
    public class PokemonToPokemonSkill : IModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PokemonId { get; set; }
        public int PokemonSkillId { get; set; }
    }
}