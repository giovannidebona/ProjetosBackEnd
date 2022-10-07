using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Domain.Models;
using Sistemarcas.Infrastructure.Context;
using Sistemarcas.Infrastructure.Data.Repositories;

namespace Sistemarcas.Infrastructure.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SistemarcasContext sqlContext;

        public CustomerRepository(SistemarcasContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}