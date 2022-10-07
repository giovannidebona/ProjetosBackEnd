using Microsoft.EntityFrameworkCore;
using Serilog;
using Sistemarcas.Domain.Configuration;
using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sistemarcas.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly SistemarcasContext _db;

        public RepositoryBase(SistemarcasContext dbContext)
        {
            this._db = dbContext;
        }
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _db.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _db.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Remove(TEntity entity)
        {
            _db.Remove(entity);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<TEntity>> GetPaged(PagingParameters pagingParameters)
        {
            return await _db.Set<TEntity>()
                    .Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize)
                    .Take(pagingParameters.PageSize)
                    .ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetWithFilter(Expression<Func<TEntity, bool>> predicate)
        {
            return await _db.Set<TEntity>().Where(predicate).ToListAsync();
        }
    }
}