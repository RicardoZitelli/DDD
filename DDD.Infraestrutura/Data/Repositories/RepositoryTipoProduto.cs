using DDD.Domain.Entities;
using DDD.Domain.Repositories.Interfaces;

namespace DDD.Infrastructure.Data.Repositories
{
    public class RepositoryTipoProduto : RepositoryBase<TipoProduto>, IRepositoryTipoProduto
    {        
        public RepositoryTipoProduto(SqlContext sqlContext) : base(sqlContext)
        {
           
        }
    }
}
