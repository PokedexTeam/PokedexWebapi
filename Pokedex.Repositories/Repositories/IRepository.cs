using System.Collections.Generic;
using System.Threading.Tasks;
using Pokedex.Repositories.Models;

namespace Pokedex.Repositories.Repositories
{
    public interface IRepository<TEntity> where TEntity : IModel
    {
        void Delete(TEntity pokemonType);
        Task<TEntity> FindOneById(int id);
        Task<IList<TEntity>> FindOneByAttribute(TEntity pType);
        Task<IList<TEntity>> GetAll();
        void Insert(TEntity value);
        void Update(TEntity value);
    }
}