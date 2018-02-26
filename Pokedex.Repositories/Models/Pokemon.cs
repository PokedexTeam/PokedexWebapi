namespace Pokedex.Repositories.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Pokemon : ISimpleModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseAttack { get; set; }
        public int BaseDefense { get; set; }
        public int BaseHP { get; set; }
        public int BaseSpAtk { get; set; }
        public int BaseSpDef { get; set; }
        public int BaseSpeed { get; set; }
    }
}
