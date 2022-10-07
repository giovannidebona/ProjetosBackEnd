using Sistemarcas.Domain.Configuration;
using Sistemarcas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Interfaces.Repositories
{
    public interface IProcessRepository
    {
        Task<Processo> Add(Processo entity);

        Task<Processo> Update(Processo entity);

        Task<IEnumerable<Processo>> GetAll();

        Task<Processo> GetById(int id);

        Task<IEnumerable<Processo>> GetPaged(PagingParameters pagingParameters);
    }
}
