using DDD.Domain.Repositories.Interfaces;
using DDD.Domain.Services.Interfaces;

namespace DDD.Domain.Services
{
    public class ServiceBase<TEntity>(IRepositoryBase<TEntity> repository) : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository = repository;

        public async Task AddAsync(TEntity obj) => await _repository.AddAsync(obj);            
        
        public async Task<TEntity?> FindByIdAsync(int id) => await _repository.GetByIdAsync(id);        
        
        public async Task<IEnumerable<TEntity>> GetAllAsync() => await _repository.GetAllAsync();
        
        public async Task RemoveAsync(TEntity obj) => await _repository.RemoveAsync(obj);
        
        public async Task UpdateAsync(TEntity obj) => await _repository.UpdateAsync(obj);        
    }
}
