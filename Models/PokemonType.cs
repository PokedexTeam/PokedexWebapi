namespace pokedex.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class PokemonType 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public List<PokemonToPokemonType> PokemonToPokemonTypes { get; set; }
    }
}
