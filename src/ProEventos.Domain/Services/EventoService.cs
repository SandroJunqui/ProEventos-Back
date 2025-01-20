using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Repositories;
using ProEventos.Domain.Interfaces.Services;

namespace ProEventos.Domain.Services
{
    public class EventoService : ServiceBase<Evento>, IEventoService
    {
        protected readonly IEventoRepository _eventoRepository;

        public EventoService(IEventoRepository eventoRepository) : base(eventoRepository)
        {
            _eventoRepository = eventoRepository ?? throw new ArgumentNullException(nameof(eventoRepository));
        }

        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes)
        {
            return await _eventoRepository.GetAllEventosAsync(includePalestrantes);
        }

        public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes)
        {
            return await _eventoRepository.GetAllEventosByTemaAsync(tema, includePalestrantes);
        }

        public async Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes)
        {
            return await _eventoRepository.GetEventoByIdAsync(eventoId, includePalestrantes);
        }
    }
}