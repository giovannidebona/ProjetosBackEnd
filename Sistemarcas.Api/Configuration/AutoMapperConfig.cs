using Sistemarcas.Api.DTO;
using Sistemarcas.Domain.Models;

namespace Sistemarcas.Presentation.Configuration
{
    public class AutoMapperConfig : AutoMapper.Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Processo, ProcessGridDTO>().ReverseMap();
            CreateMap<Processo, ProcessDTO>().ReverseMap();
            CreateMap<Processos_Marcas, ProcessMarcaGridDTO>().ReverseMap();
        }
    }
}
