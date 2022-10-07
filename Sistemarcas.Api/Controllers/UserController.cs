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

namespace Sistemarcas.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
    }
}