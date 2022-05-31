using DDD.Domain.Interfaces.Repositories;
using DDD.Dominio.Entities;

namespace DDD.Infrastructure.Data.Repositories
{
    public class RepositoryCliente<TEntity> : RepositoryBase<Cliente>,IRepositoryCliente
    {
        private readonly SqlContext sqlContext;
          
        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }



    }
}
