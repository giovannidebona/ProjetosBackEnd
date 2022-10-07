using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this._repository = repository;
        }

        public async Task Add(TEntity obj)
        {
            await _repository.Add(obj);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Remove(TEntity obj)
        {
            await _repository.Remove(obj);
        }

        public async Task Update(TEntity obj)
        {
            await _repository.Update(obj);
        }
    }
}