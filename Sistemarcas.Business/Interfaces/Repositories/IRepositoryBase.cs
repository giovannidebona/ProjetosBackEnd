using Sistemarcas.Domain.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetPaged(PagingParameters pagingParameters);

        Task<TEntity> Add(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task<bool> Remove(TEntity entity);

        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> GetById(int id);

        Task<IEnumerable<TEntity>> GetWithFilter(Expression<Func<TEntity, bool>> predicate);
    }
}
