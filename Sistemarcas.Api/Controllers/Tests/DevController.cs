using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sistemarcas.Domain.Models;
using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Application.CQRS.Commands;
using MediatR;
using Sistemarcas.Models.Tests.Enum;

namespace Sistemarcas.Api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/dev")]

    public class DevController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IDevRepository _devRepository;

        public DevController(IMediator mediator,
                            IDevRepository devRepository) : base()
        {
            _devRepository = devRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dev>>> GetAll()
        {
            var dev = await _devRepository.GetAll();

            return Ok(dev);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Dev>>> GetById([FromRoute] int id)
        {
            var dev = await _devRepository.GetById(id);

            return Ok(dev);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Dev>>> Add(Dev dev)
        {
            var result = await _devRepository.Add(dev);

            return Ok(result);
        }

        [HttpPost("AddDevResponse")]
        public Task<Dev> AddDevResponse([FromBody] DevRequest request)
        {
            return _mediator.Send(request);
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<Dev>>> Update(Dev dev)
        {
            var result = await _devRepository.Update(dev);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<IEnumerable<Dev>>> Remove(Dev dev)
        {
            var result = await _devRepository.Remove(dev);

            return Ok(result);
        }
    }
}
