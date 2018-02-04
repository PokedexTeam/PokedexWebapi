namespace Pokedex.Repositories.Models
{
    interface ISimpleModel : IModel
    {
        string Name { get; set; }
    }
}
