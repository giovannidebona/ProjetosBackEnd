using Microsoft.EntityFrameworkCore;
using Sistemarcas.Domain.Configuration;
using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Domain.Models;
using Sistemarcas.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Infrastructure.Data.Repositories
{
    public class ProcessRepository : IProcessRepository
    {
        private readonly IRepositoryBase<Processo> _repositoryBase;
        private readonly SistemarcasContext _dbContext;

        public ProcessRepository(IRepositoryBase<Processo> repositoryBase,
                                        SistemarcasContext dbContext)
        {
            _repositoryBase = repositoryBase;
            _dbContext = dbContext;
        }

        public async Task<Processo> Add(Processo entity)
        {
            await _repositoryBase.Add(entity);
            return entity;
        }

        public async Task<IEnumerable<Processo>> GetAll()
        {
            return await _repositoryBase.GetAll();
        }

        public async Task<Processo> GetById(int id)
        {
            return await _repositoryBase.GetById(id);
        }

        public async Task<Processo> Update(Processo entity)
        {
            return await _repositoryBase.Update(entity);
        }

        public async Task<IEnumerable<Processo>> GetPaged(PagingParameters pagingParameters)
        {
            return await _dbContext.Processos
                .AsNoTracking()
                .Include(c => c.Processo_Marca).ThenInclude(c => c.Classe)
                .Include(c => c.SituacoesRegistro)
                .Include(c => c.OrdemServico)
                .Include(c => c.Cliente)
                .Include(c => c.Empresa)
                .OrderBy(c => c.Numeroprocesso)
                .Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize)
                .Take(pagingParameters.PageSize)
                .ToListAsync();
        }

    }
}
