using Microsoft.EntityFrameworkCore;
using Sistemarcas.Domain.Configuration;
using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Domain.Models;
using Sistemarcas.Infrastructure.Context;
using Sistemarcas.Models.Tests.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Infrastructure.Data.Repositories
{
    public class DevRepository : RepositoryBase<Dev>, IDevRepository
    {
        //private readonly IDevExternalRepository _devExternalRepository;

        public DevRepository(SistemarcasContext context) : base(context)
        {

        }
    }
}
