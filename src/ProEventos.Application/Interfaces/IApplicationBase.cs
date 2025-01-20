using ProEventos.Application.DTO;
using ProEventos.Domain.Entities;

namespace ProEventos.Application.Interfaces
{
    public interface IApplicationBase<TEntity, TEntityDTO>
        where TEntity : EntityBase
        where TEntityDTO : DTOBase
    {
        void Add(TEntityDTO entity);
        void Update(TEntityDTO entity);
        void Delete(TEntityDTO entity);
        void DeleteRange(TEntityDTO[] entity);

        Task<bool> SaveChangesAsync();
    }
}
