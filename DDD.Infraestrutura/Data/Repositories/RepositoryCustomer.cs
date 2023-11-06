using DDD.Domain.Entities;
using DDD.Domain.Repositories.Interfaces;

namespace DDD.Infrastructure.Data.Repositories
{
    public class RepositoryCustomer : RepositoryBase<Customer>, IRepositoryCustomer
    {
        public RepositoryCustomer(SqlContext sqlContext) : base(sqlContext) { }
    }
}
