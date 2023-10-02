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

        public void Add(TEntity obj) => repository.Add(obj);            
        
        public TEntity FindById(int id) => repository.GetById(id);        
        
        public IEnumerable<TEntity> GetAll() => repository.GetAll();
        
        public void Remove(TEntity obj) => repository.Remove(obj);
        
        public void Update(TEntity obj) => repository.Update(obj);        
    }
}
