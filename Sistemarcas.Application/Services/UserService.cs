using Sistemarcas.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Application.Services
{
    public class UserService : IUsuarioService
    {
        IUsuarioService _usuarioService;

        public UserService(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public async Task<bool> DisableUser(int id)
        {
            return await _usuarioService.DisableUser(id);
        }
    }
}
