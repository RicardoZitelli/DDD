using DDD.Domain.Interfaces.Repositories;
using DDD.Dominio.Entities;

namespace DDD.Infrastructure.Data.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        public readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)  
        {
            this.sqlContext = sqlContext;
        }
    }
}
