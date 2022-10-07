using Sistemarcas.Domain.Configuration;
using Sistemarcas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Interfaces.Repositories
{
    public interface IPositionRepository : IRepositoryBase<Cargos>
    {
        PagedList<Cargos> GetPaged3(PagingParameters pagingParameters);
    }

}
