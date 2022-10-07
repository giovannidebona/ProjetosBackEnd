using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistemarcas.Api.Controllers
{
    public class ServiceOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
