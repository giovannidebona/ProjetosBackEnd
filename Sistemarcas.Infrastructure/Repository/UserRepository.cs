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
    public class UserRepository : RepositoryBase<Usuario>, IUserRepository
    {
        public UserRepository(SistemarcasContext context) : base(context) { }

    }
}
