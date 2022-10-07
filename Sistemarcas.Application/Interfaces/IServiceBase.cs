using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistemarcas.Application.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task Remove(TEntity entity);

        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> GetById(int id);
    }
}