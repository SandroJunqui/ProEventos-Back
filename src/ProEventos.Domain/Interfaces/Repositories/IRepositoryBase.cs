using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T>
        where T : EntityBase
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(T[] entities);

        Task<bool> SaveChangesAsync();
    }
}
