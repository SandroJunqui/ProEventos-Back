using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Repositories;
using ProEventos.Domain.Interfaces.Services;

namespace ProEventos.Domain.Services
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : EntityBase
    {
        protected readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository ?? throw new System.ArgumentNullException(nameof(repository));
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public void DeleteRange(T[] entities)
        {
            _repository.DeleteRange(entities);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _repository.SaveChangesAsync();
        }
    }
}
