using DDD.Domain.Entities;
using DDD.Domain.Repositories.Interfaces;

namespace DDD.Infrastructure.Data.Repositories
{
    public class RepositoryProductType : RepositoryBase<ProductType>, IRepositoryProductType
    {        
        public RepositoryProductType(SqlContext sqlContext) : base(sqlContext)
        {
           
        }
    }
}
