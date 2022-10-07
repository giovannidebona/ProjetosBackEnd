using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistemarcas.Domain.Models;
using Sistemarcas.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Sistemarcas.Api.DTO;
using AutoMapper;
using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Domain.Configuration;

namespace Sistemarcas.Api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/process")]

    public class ProcessController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProcessRepository _processRepository;

        public ProcessController(IMapper mapper, IProcessRepository processRepository) : base()
        {
            _mapper = mapper;
            _processRepository = processRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProcessGridDTO>>> GetAll(
                    [FromServices] SistemarcasContext context)
        {
            var process = await _processRepository.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProcessGridDTO>>(process));
        }

        [HttpGet]
        [Route("GetPaged")]
        public async Task<ActionResult<IEnumerable<ProcessGridDTO>>> GetPaged([FromQuery] PagingParameters pagingParameters)
        {
            var process = await _processRepository.GetPaged(pagingParameters);

            return Ok(_mapper.Map<IEnumerable<ProcessGridDTO>>(process));
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<IEnumerable<ProcessGridDTO>>> GetById(
                    [FromServices] SistemarcasContext context, int id)
        {
            var process = await _processRepository.GetById(id);

            return Ok(_mapper.Map<ProcessGridDTO>(process));
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<ProcessGridDTO>>> Add(
                   [FromServices] SistemarcasContext context, ProcessDTO process)
        {
            var processo = _mapper.Map<Processo>(process);

            var result = await _processRepository.Add(processo);

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<ProcessGridDTO>>> Update(
                 [FromServices] SistemarcasContext context, ProcessDTO processDTO)
        {
            var process = _processRepository.GetById(processDTO.Id);

            if (process == null) return NotFound();

            var processMaped = _mapper.Map<Processo>(process);

            var result = await _processRepository.Update(processMaped);

            return Ok(result);
        }
    }
}
