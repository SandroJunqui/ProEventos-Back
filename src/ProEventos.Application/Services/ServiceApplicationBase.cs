using AutoMapper;
using ProEventos.Application.DTO;
using ProEventos.Application.Interfaces;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Services;

namespace ProEventos.Application.Services
{
    public class ServiceApplicationBase<TEntity, TEntityDTO> : IApplicationBase<TEntity, TEntityDTO>
        where TEntity : EntityBase
        where TEntityDTO : DTOBase
    {
        private readonly IMapper _iMapper;
        private readonly IServiceBase<TEntity> _service;

        public ServiceApplicationBase(IMapper iMapper, IServiceBase<TEntity> service) : base()
        {
            _iMapper = iMapper;
            _service = service;
        }

        public void Add(TEntityDTO entity)
        {
            try
            {
                var entityMap = _iMapper.Map<TEntity>(entity);
                _service.Add(entityMap);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(TEntityDTO entity)
        {
            try
            {
                var entityMap = _iMapper.Map<TEntity>(entity);
                _service.Update(entityMap);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(TEntityDTO entity)
        {
            try
            {
                var entityMap = _iMapper.Map<TEntity>(entity);
                _service.Delete(entityMap);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteRange(TEntityDTO[] entity)
        {
            var entityMap = _iMapper.Map<TEntity[]>(entity);
            _service.DeleteRange(entityMap);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _service.SaveChangesAsync();
        }
    }
}
