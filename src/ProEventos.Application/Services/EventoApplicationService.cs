using AutoMapper;
using ProEventos.Application.DTO;
using ProEventos.Application.Interfaces;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Services;

namespace ProEventos.Application.Services
{
    public class EventoApplicationService : ServiceApplicationBase<Evento, EventoDTO>, IEventoApplication
    {
        public EventoApplicationService(IMapper iMapper, IServiceBase<Evento> service) : base(iMapper, service)
        {
        }

        public Task<EventoDTO[]> GetAllEventosAsync(bool includePalestrantes)
        {
            return GetAllEventosAsync(includePalestrantes);
        }

        public Task<EventoDTO[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes)
        {
            return GetAllEventosByTemaAsync(tema, includePalestrantes);
        }

        public Task<EventoDTO> GetEventoByIdAsync(int eventoId, bool includePalestrantes)
        {
            return GetEventoByIdAsync(eventoId, includePalestrantes);
        }
    }
}
