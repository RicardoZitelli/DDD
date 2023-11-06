using DDD.Domain.Entities;
using DDD.Domain.Repositories.Interfaces;

namespace DDD.Infrastructure.Data.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {       
        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
           
        }
    }
}
