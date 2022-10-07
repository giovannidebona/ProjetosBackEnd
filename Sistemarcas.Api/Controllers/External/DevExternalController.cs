using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Sistemarcas.Domain.Models;
using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Application.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Sistemarcas.Api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/devexternal")]

    public class DevExternalController : Controller
    {
        private readonly ILogger<DevExternalController> _logger;
        private readonly IDevExternalRepository _devExternalRepository;
        private readonly IDevExternalService _devExternalService;

        public DevExternalController(ILogger<DevExternalController> logger,
                            IDevExternalRepository devRepository,
                            IDevExternalService devService) : base()
        {
            _logger = logger;
            _devExternalRepository = devRepository;
            _devExternalService = devService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<DevExternal>>> GetAll()
        {
            var result = await _devExternalRepository.GetAll();

            if (result == null) { return new StatusCodeResult(400); }

            _logger.LogInformation("Todos os Devs selecionados");

            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<DevExternal>>> GetById([FromRoute] int id)
        {
            var result = await _devExternalRepository.GetById(id);

            if (result == null) { return new StatusCodeResult(400); }

            _logger.LogInformation("Dev id " + id + " selecionado.");

            return Ok(result);
        }

        [HttpGet("OrganizeEmails")]
        public async Task<ActionResult<bool>> OrganizeEmails()
        {
            var result = await _devExternalService.OrganizeEmails();

            if (!result) { return new StatusCodeResult(400); }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<DevExternal>>> Add(DevExternal dev)
        {
            try
            {
                var result = await _devExternalRepository.Add(dev);

                if (result == null) { return new StatusCodeResult(400); }

                _logger.LogInformation("Dev Adicionado");

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Falha ao adicionar dev: " + ex.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<DevExternal>>> Update(DevExternal dev)
        {
            try
            {
                var result = await _devExternalRepository.Update(dev);

                if (result == null) { return new StatusCodeResult(400); }

                _logger.LogInformation("Dev Atualizado");

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Falha ao atualizar dev: " + ex.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete]
        public async Task<ActionResult<IEnumerable<DevExternal>>> Remove(int id)
        {
            try
            {
                var dev = await _devExternalRepository.GetById(id);

                var result = await _devExternalRepository.Remove(dev);

                if (!result) { return new StatusCodeResult(400); }

                _logger.LogInformation("Dev Removido");

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Falha ao excluir dev: " + ex.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}
