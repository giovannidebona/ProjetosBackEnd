using MediatR;
using Sistemarcas.Application.CQRS.Commands;
using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sistemarcas.Application.CQRS.Handlers
{
    public class CreateDevHandler : IRequestHandler<DevRequest, Dev>
    {
        private readonly IDevRepository _devRepository;

        public CreateDevHandler(IDevRepository devRepository) : base()
        {
            _devRepository = devRepository;
        }

        public Task<Dev> Handle(DevRequest request, CancellationToken cancellationToken)
        {
            var dev = new Dev
            {
                Name = request.Name,
                Login = request.Login,
                Avatar = request.Avatar,
                Email = request.Email,
                CreatedAt = request.CreatedAt,
                Squad = request.Squad,
                Tag = request.Tag
            };

            return _devRepository.Add(dev);
        }
    }
}