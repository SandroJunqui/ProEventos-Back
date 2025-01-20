using AutoMapper;
using ProEventos.Application.DTO;
using ProEventos.Domain.Entities;

namespace ProEventos.Application
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {
            CreateMap<Evento, EventoDTO>().ReverseMap();
            CreateMap<Lote, LoteDTO>().ReverseMap();
            CreateMap<Palestrante, PalestranteDTO>().ReverseMap();
            CreateMap<RedeSocial, RedeSocialDTO>().ReverseMap();
        }
    }
}
