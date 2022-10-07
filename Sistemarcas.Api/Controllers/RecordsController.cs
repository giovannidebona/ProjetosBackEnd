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
using Sistemarcas.Domain.Configuration;
using Sistemarcas.Domain.Interfaces.Repositories;
using Newtonsoft.Json;

namespace Sistemarcas.Api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/records")]
    public class RecordsController : ControllerBase
    {
        private readonly ILogger<RecordsController> _logger;
        private readonly IPositionRepository _positionRepository;

        public RecordsController(ILogger<RecordsController> logger,
                                IPositionRepository PositionRepository)
        {
            _logger = logger;
            _positionRepository = PositionRepository;
        }

        #region Positions

        [HttpGet]
        [Route("position")]
        public async Task<ActionResult<IEnumerable<Cargos>>> GetAllPositions([FromServices] SistemarcasContext context)
        {
            var cargos = await context.Cargos.OrderBy(c => c.Nome).ToListAsync();
            return cargos;
        }

        [HttpGet]
        [Route("position/GetPaged")]
        public async Task<ActionResult<IEnumerable<Cargos>>> GetPagedPositions([FromQuery] PagingParameters pagingParameters)
        {
            var positions = await _positionRepository.GetPaged(pagingParameters);

            return Ok(positions);
        }

        [HttpGet]
        [Route("position/GetPaged2")]
        public ActionResult<IEnumerable<Cargos>> GetPagedPositions2([FromQuery] PagingParameters pagingParameters)
        {
            var positions = _positionRepository.GetPaged3(pagingParameters);
            var metadata = new
            {
                positions,
                positions.TotalCount,
                positions.PageSize,
                positions.CurrentPage,
                positions.TotalPages,
                positions.HasNext,
                positions.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            return Ok(metadata);
        }

        [HttpGet]
        [Route("position/GetById")]
        public async Task<ActionResult<Cargos>> GetPositionById([FromServices] SistemarcasContext context, int positionId)
        {
            var cargo = await context.Cargos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == positionId);

            if (cargo == null) return NotFound();

            return cargo;
        }

        [HttpPost]
        [Route("position")]
        public async Task<ActionResult<Cargos>> AddPosition([FromServices] SistemarcasContext context, [FromBody] Cargos cargo)
        {
            if (ModelState.IsValid)
            {
                context.Cargos.Add(cargo);
                await context.SaveChangesAsync();
                return cargo;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut]
        [Route("position")]
        public async Task<ActionResult<Cargos>> UpdatePosition([FromServices] SistemarcasContext context, [FromBody] Cargos cargo)
        {
            if (ModelState.IsValid)
            {
                context.Cargos.Update(cargo);
                await context.SaveChangesAsync();
                return cargo;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("position")]
        public async Task<ActionResult<bool>> DeletePosition([FromServices] SistemarcasContext context, int positionId)
        {
            var cargo = await context.Cargos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == positionId);

            if (cargo == null) return NotFound();

            var deleted = context.Cargos.Remove(cargo);
            await context.SaveChangesAsync();

            return true;
        }

        #endregion

        [HttpGet]
        [Route("size")]
        public async Task<ActionResult<IEnumerable<Portes>>> GetAllSizes([FromServices] SistemarcasContext context)
        {
            var portes = await context.Portes.ToListAsync();

            return portes;
        }
    }
}
