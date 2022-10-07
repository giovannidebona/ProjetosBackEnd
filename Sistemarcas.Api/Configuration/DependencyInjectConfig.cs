using Sistemarcas.Infrastructure.Context;
using Microsoft.Extensions.DependencyInjection;
using Sistemarcas.Domain.Interfaces.Repositories;
using Sistemarcas.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Sistemarcas.Application.Interfaces;
using Sistemarcas.Application.Services;
using MediatR;
using System.Reflection;
using Sistemarcas.Application.CQRS.Handlers;

namespace Sistemarcas.Presentation.Configuration
{
    public static class DependencyInjectConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //classe criada para resolver injeções de dependencias

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<DbContext, SistemarcasContext>();

            services.AddScoped<IProcessRepository, ProcessRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();

            services.AddScoped<IDevExternalRepository, DevExternalRepository>();
            services.AddScoped<IDevExternalService, DevExternalService>();

            services.AddScoped<IDevService, DevService>();
            services.AddScoped<IDevRepository, DevRepository>();

            services.AddScoped<IUserRepository, UserRepository>();

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddMediatR(typeof(CreateDevHandler));

            return services;
        }
    }
}
