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
    public class PositionRepository : RepositoryBase<Cargos>, IPositionRepository
    {
        public PositionRepository(SistemarcasContext context) : base(context) { }

        public async Task<IEnumerable<Cargos>> GetPaged2(PagingParameters pagingParameters)
        {
            return await _db.Cargos
                .AsNoTracking()
                .OrderBy(c => c.Nome)
                .Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize)
                .Take(pagingParameters.PageSize)
                .ToListAsync();
        }

        public PagedList<Cargos> GetPaged3(PagingParameters pagingParameters)
        {
            return PagedList<Cargos>.ToPagedList(_db.Cargos.OrderBy(on => on.Nome),
                pagingParameters.PageNumber,
                pagingParameters.PageSize);
        }
    }
}
