namespace DDD.Domain.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(int id);
    }
}
