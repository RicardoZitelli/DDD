using DDD.Domain.Entities;
using DDD.Domain.Repositories.Interfaces;

namespace DDD.Infrastructure.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {       
        public RepositoryProduct(SqlContext sqlContext) : base(sqlContext)
        {
           
        }
    }
}
