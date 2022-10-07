using Sistemarcas.Domain.Configuration;
using Sistemarcas.Domain.Models;
using Sistemarcas.Models.Tests.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Interfaces.Repositories
{
    public interface IDevExternalRepository
    {
        Task<DevExternal> Add(DevExternal entity);

        Task<DevExternal> Update(DevExternal entity);

        Task<bool> Remove(DevExternal dev);

        Task<IEnumerable<DevExternal>> GetAll();

        Task<DevExternal> GetById(int id);

        Task<bool> SyncDataToDev(DevExternal devExternal, CommandTypeTest commandType);
    }

}
