using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemarcas.Application.Interfaces;
using Sistemarcas.Domain.Models;

namespace Sistemarcas.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<bool> DisableUser(int id);
    }
}
