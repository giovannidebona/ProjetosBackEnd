using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sistemarcas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistemarcas.Infrastructure.Context;
using Sistemarcas.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Text;
using Sistemarcas.Api.DTO;
using Sistemarcas.Presentation.Services;
using Sistemarcas.Domain.Interfaces.Repositories;

namespace Sistemarcas.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IUserRepository _userRepository;

        public AuthController(ILogger<AuthController> logger,
                                IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("sign-in")]
        public async Task<ActionResult<dynamic>> SignIn([FromBody] UserDTO userDTO)
        {
            string key = "sistemarcas@#";
            string senhaCripto = CalculateSHA1(key + userDTO.Password);

            var user = (await _userRepository.GetWithFilter(b => b.Email == userDTO.Email && b.Password == senhaCripto)).FirstOrDefault();

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);

            user.Password = "";

            return new
            {
                user = user,
                accessToken = token
            };
        }

        private static string CalculateSHA1(string text)
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                System.Security.Cryptography.SHA1CryptoServiceProvider cryptoTransformSHA1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
                return hash;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }
    }
}
