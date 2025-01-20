using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces.Services
{
    public interface IEventoService : IServiceBase<Evento>
    {
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes);
    }
}
