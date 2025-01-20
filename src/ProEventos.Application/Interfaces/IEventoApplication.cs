using ProEventos.Application.DTO;
using ProEventos.Domain.Entities;

namespace ProEventos.Application.Interfaces
{
    public interface IEventoApplication : IApplicationBase<Evento, EventoDTO>
    {
        Task<EventoDTO[]> GetAllEventosAsync(bool includePalestrantes);
        Task<EventoDTO[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
        Task<EventoDTO> GetEventoByIdAsync(int eventoId, bool includePalestrantes);
    }
}
