using DDD.Application.Dtos.Requests;
using DDD.Application.Dtos.Responses;
using DDD.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public void Add(TEntity entity)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(entity);
                sqlContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Remove(TEntity entity)
        {
            sqlContext.Set<TEntity>().Remove(entity);
            sqlContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll() => sqlContext.Set<TEntity>().ToList();

        public TEntity GetById(int id) => sqlContext.Set<TEntity>().Find(id);

        public void Update(TEntity entity)
        {
            sqlContext.Entry(entity).State = EntityState.Modified;
            sqlContext.SaveChanges();
        }
    }
}
