using Sistemarcas.Application.Interfaces;
using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Application.Services
{
    public class DevService : IDevService
    {
        IDevRepository _devRepository;

        public DevService(IDevRepository devRepository)
        {
            _devRepository = devRepository;
        }

        public bool SyncData()
        {
            return false;
        }
    }
}
