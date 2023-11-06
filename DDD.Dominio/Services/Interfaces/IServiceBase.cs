namespace DDD.Domain.Services.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
        Task RemoveAsync(TEntity obj);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> FindByIdAsync(int id);
    }
}
