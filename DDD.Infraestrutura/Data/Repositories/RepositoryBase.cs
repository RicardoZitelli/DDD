using DDD.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;
        
        public RepositoryBase(SqlContext sqlContext) => this.sqlContext = sqlContext;

        public async Task AddAsync(TEntity entity)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(entity);
                await sqlContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task RemoveAsync(TEntity entity)
        {
            sqlContext.Set<TEntity>().Remove(entity);
            await sqlContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync() => await sqlContext.Set<TEntity>().ToListAsync();

        public async Task<TEntity?> GetByIdAsync(int id) => await sqlContext.Set<TEntity>().FindAsync(id);

        public async Task UpdateAsync(TEntity entity)
        {
            sqlContext.Entry(entity).State = EntityState.Modified;
            await sqlContext.SaveChangesAsync();
        }
    }
}
