using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces.Services
{
    public interface IServiceBase<T>
    where T : EntityBase
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(T[] entities);

        Task<bool> SaveChangesAsync();
    }
}
