using AutoMapper;
using Seventh.Desafio.Business.DTO;
using Seventh.Desafio.Business.Entidades;

namespace Seventh.Desafio.Presentation.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Servidor, ServidorDTO>().ReverseMap();
            CreateMap<Video, VideoDTO>().ReverseMap();
        }
    }
}
