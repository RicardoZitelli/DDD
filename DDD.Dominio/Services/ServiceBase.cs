using DDD.Domain.Repositories.Interfaces;
using DDD.Domain.Services.Interfaces;

namespace DDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository) { 
            this.repository = repository;
        }

        public async Task AddAsync(TEntity obj) => await repository.AddAsync(obj);            
        
        public async Task<TEntity?> FindByIdAsync(int id) => await repository.GetByIdAsync(id);        
        
        public async Task<IEnumerable<TEntity>> GetAllAsync() => await repository.GetAllAsync();
        
        public async Task RemoveAsync(TEntity obj) => await repository.RemoveAsync(obj);
        
        public async Task UpdateAsync(TEntity obj) => await repository.UpdateAsync(obj);        
    }
}
